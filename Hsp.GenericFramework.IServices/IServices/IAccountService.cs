using Hsp.GenericFramework.Commons.Security;
using Hsp.GenericFramework.Dto.Models;

namespace Hsp.GenericFramework.IServices.IServices
{
    public interface IAccountService
    {
        ErrorModel<UserProfileLogin> SignIn(string userName, string password);
    }
}
