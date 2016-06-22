using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hsp.GenericFramework.Commons.Dtos.Models;
using Hsp.GenericFramework.Commons.Security;
using Hsp.GenericFramework.Entities.Models;
using Hsp.GenericFramework.IGenericRepositories;
using Hsp.GenericFramework.IServices.IServices;
using Hsp.GenericFramework.IUnitOfWorks;
using Hsp.GenericFramework.Services.Base;
using Hsp.GenericFramework.Commons;
using Hsp.GenericFramework.Commons.Dtos;
using System;
using Hsp.GenericFramework.Commons.Logging;

namespace Hsp.GenericFramework.Services.Services
{
    public class AccountService : BaseService, IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<User> _userRepository;
        private readonly IGenericRepository<GroupUser> _groupUserRepository;

        public AccountService(IUnitOfWork unitOfWork, IGenericRepository<User> userRepository, IGenericRepository<GroupUser> groupUserRepository, ILogManager<AccountService> logManager) : base(unitOfWork, logManager.GetLog())
        {
            _userRepository = userRepository;
            _groupUserRepository = groupUserRepository;
            _unitOfWork = unitOfWork;
        }
        public ErrorModel<UserProfileLogin> SignIn(string userName, string password)
        {
            ErrorModel<UserProfileLogin> errorModel = new ErrorModel<UserProfileLogin>();
            // check user name is valid and get information of this user
            var userValid = CheckUserName(userName);
            if(userValid == null)
            {
                errorModel.Code = Consts.ErrorStatus.Error;
                errorModel.Message = "Invalid login attempt.";
                return errorModel;
            }

                        
            var passwordCombined = string.Format("{0}{1}", password, userValid.SecurityStamp);
            var isValidPassword = HspSecurity.ValidatePassword(passwordCombined, userValid.PasswordHash);
            userValid = CheckLockLoginFailNumber(userValid, isValidPassword);
            if (userValid.IsLocked)
            {
                errorModel.Code = Consts.ErrorStatus.Error;
                errorModel.Message = string.Format("You have logined failt {0} times. Please try it after {1} munites", Consts.Loopkups.LockLoginFailNumber, Consts.Loopkups.LockLoginFailResetTime);
                return errorModel;
            }


            if (!isValidPassword)
            {
                errorModel.Code = Consts.ErrorStatus.Error;
                errorModel.Message = "Invalid login attempt.";
                return errorModel;
            }

            UserProfileLogin userProfileLogin = new UserProfileLogin();
            userProfileLogin.UserKey = userValid.Id;
            userProfileLogin.UserName = userValid.UserName;
            userProfileLogin.GroupUserId = userValid.GroupUserId;
            // load role 
            userProfileLogin.UserRoles = userValid.GroupUser != null
                ? userValid.GroupUser.GroupUserRoles.Select(x =>
                {
                    var groupUserRole = x.GroupUser.GroupUserRoles.FirstOrDefault();
                    return new GroupUserRoleModel()
                    {
                        GroupUserId = x.GroupUserId,
                        RoleId = x.RoleId,
                        RoleName = groupUserRole != null ? groupUserRole.Role.RoleName : string.Empty
                    };
                }).ToList()
                : new List<GroupUserRoleModel>();
            errorModel.ObjectData = userProfileLogin;
            return errorModel;
        }

        private User CheckUserName(string userName)
        {
            var user = _userRepository.Get(x => x.IsActive && x.UserName == userName).FirstOrDefault();
            return user;
        }
        private User CheckLockLoginFailNumber(User user, bool isValidPassword)
        {
            // Reset LoginFailCount = 0 if login success
            if (isValidPassword && !user.IsLocked)
            {
                if (user.LoginFailCount > 0)
                {                    
                    user.IsLocked = false;
                    user.LoginFailCount = 0;
                    user.LastestLoginAt = DateTime.UtcNow;
                }
            }
            else {
                var lastestLoginFailAt = user.LastestLoginFailAt != null ? user.LastestLoginFailAt.Value.AddMinutes(Consts.Loopkups.LockLoginFailResetTime) : DateTime.UtcNow;

                //Reset LoginFailCount = 0 if UtcNow > (LastestLoginFailAt + LockLoginFailResetTime) 
                if (user.LastestLoginFailAt == null || (user.LastestLoginFailAt != null && DateTime.UtcNow > lastestLoginFailAt))
                {
                    user.IsLocked = false;
                    user.LoginFailCount = isValidPassword? 0 : 1;
                    user.LastestLoginFailAt = DateTime.UtcNow;
                }
                //Increment LoginFailCount++ if UtcNow <= (LastestLoginFailAt + LockLoginFailResetTime) 
                else if ((user.LoginFailCount == 0) || (user.LoginFailCount < 4 && user.LastestLoginFailAt != null && DateTime.UtcNow <= lastestLoginFailAt))
                {
                    user.IsLocked = false;
                    user.LoginFailCount++;
                    user.LastestLoginFailAt = DateTime.UtcNow;
                }

                //Lock user if LoginFailCount == 5
                else
                {                    
                    user.IsLocked = true;
                    user.LockedDate = DateTime.UtcNow;
                    user.LoginFailCount = 5;
                    user.LastestLoginFailAt = DateTime.UtcNow;
                }
            }
            
            UpdateLockLoginFailNumber(user);
            return user;
        }

        private bool UpdateLockLoginFailNumber(User user)
        {
            _userRepository.Update(user);
            return _unitOfWork.SaveChanges() > 0;
        }

    }
}
