using System;
using System.Collections.Generic;
using Hsp.GenericFramework.Dto.Models.Models;

namespace Hsp.GenericFramework.Commons.Security
{
    public class UserProfileLogin
    {
        public List<GroupUserRoleModel> UserRoles { get; set; }
        public Guid UserKey { get; set; }
        public string UserName { get; set; }
        public int CurrentLanguageId { get; set; }
        public Guid GroupUserId { get; set; }
    }
}
