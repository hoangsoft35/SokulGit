using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class MenuItemTypeTranslation : BaseEntityWithUserInformation
    {
        [Key, Column(Order = 1)]
        public Guid MenuItemTypeId { get; set; }
        public string MenuItemTypeName { get; set; }
        [Key, Column(Order = 2)]
        public int LanguageId { get; set; }
    }
}
