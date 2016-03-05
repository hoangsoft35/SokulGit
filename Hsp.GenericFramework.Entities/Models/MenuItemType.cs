using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Hsp.GenericFramework.Entities.Models
{
    public class MenuItemType: BaseEntity
    {
        public MenuItemType()
        {
                MenuItemTypeTranslations = new Collection<MenuItemTypeTranslation>();
        }
        [Key]
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<MenuItemTypeTranslation> MenuItemTypeTranslations { get; set; } 
    }
}
