using System;

namespace Hsp.GenericFramework.Dto.Models.Models
{
    public class GroupUserRoleModel
    {
        public Guid RoleId { get; set; }
        public Guid GroupUserId { get; set; }
        public string RoleName { get; set; }

    }
}
