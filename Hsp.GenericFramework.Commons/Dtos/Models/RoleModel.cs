using System;
using Hsp.GenericFramework.Commons.Dtos.Base;

namespace Hsp.GenericFramework.Commons.Dtos.Models
{
    public class RoleModel: BaseEntityModel
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public bool IsActive { get; set; }

    }
}
