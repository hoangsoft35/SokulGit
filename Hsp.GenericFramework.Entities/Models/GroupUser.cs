using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class GroupUser: BaseEntityWithoutUserInformation{
        public GroupUser()
        {
            GroupUserRoles=new Collection<GroupUserRole>();
            Users=new Collection<User>();
        }
        [Key]
        public Guid Id { get; set; }
        public string GroupUserName { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<GroupUserRole> GroupUserRoles { get; set; }
        public virtual ICollection<User> Users { get; set; } 
    }
}
