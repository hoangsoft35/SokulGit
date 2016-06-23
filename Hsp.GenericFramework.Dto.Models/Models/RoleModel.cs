using System;
using Hsp.GenericFramework.Dto.Models.Base;

namespace Hsp.GenericFramework.Dto.Models.Models
{
    public class RoleModel: BaseEntityModel
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public bool IsActive { get; set; }

    }
}
