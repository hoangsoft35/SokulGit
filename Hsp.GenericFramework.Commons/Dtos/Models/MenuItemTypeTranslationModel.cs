using System;
using Hsp.GenericFramework.Commons.Dtos.Base;

namespace Hsp.GenericFramework.Commons.Dtos.Models
{
    public class MenuItemTypeTranslationModel : BaseEntityModel
    {
        public Guid MenuItemTypeId { get; set; }
        public string MenuItemTypeName { get; set; }
        public int LanguageId { get; set; }
    }
}
