using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class MenuItemAuthorisation : BaseEntityWithUserInformation
    {
        [Key,Column(Order = 1)]
        public Guid MenuItemId { get; set; }
        [Key, Column(Order = 2)]
        public Guid RoleId { get; set; }
        public virtual MenuItem MenuItem { get; set; }
        public virtual Role Role { get; set; }
    }
}
