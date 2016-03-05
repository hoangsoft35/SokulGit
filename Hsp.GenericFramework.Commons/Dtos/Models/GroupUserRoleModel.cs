using System;

namespace Hsp.GenericFramework.Commons.Dtos.Models
{
    public class GroupUserRoleModel
    {
        public Guid RoleId { get; set; }
        public Guid GroupUserId { get; set; }
        public string RoleName { get; set; }

    }
}
