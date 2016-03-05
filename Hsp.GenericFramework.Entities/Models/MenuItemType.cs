using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class MenuItemType: BaseEntityWithUserInformation
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
