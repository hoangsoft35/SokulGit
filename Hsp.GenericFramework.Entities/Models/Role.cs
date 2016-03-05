using System;
using System.ComponentModel.DataAnnotations;

namespace Hsp.GenericFramework.Entities.Models
{
    public class Role:BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public bool IsActive { get; set; }
    }
}
