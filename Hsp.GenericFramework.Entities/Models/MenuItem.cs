using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class MenuItem : BaseEntityWithUserInformation
    {
        public MenuItem()
        {
            MenuItemTranslations = new Collection<MenuItemTranslation>();
            MenuItemAuthorisations = new List<MenuItemAuthorisation>();
        }

        [Key]
        public Guid Id { get; set; }
        public Guid MenuItemTypeId { get; set; }
        public bool IsRoot { get; set; }
        public bool IsActive { get; set; }
        public Guid ParentId { get; set; }
        public bool IsTitle { get; set; }
        public bool IsLink { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public int SectionParameter { get; set; }
        public int Order { get; set; }
        public virtual ICollection<MenuItemTranslation> MenuItemTranslations { get; set; }
        public virtual MenuItemType MenuItemType { get; set; }
        public virtual ICollection<MenuItemAuthorisation> MenuItemAuthorisations { get; set; } 
    }
}
