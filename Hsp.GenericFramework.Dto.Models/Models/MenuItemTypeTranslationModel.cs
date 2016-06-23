using System;
using Hsp.GenericFramework.Dto.Models.Base;

namespace Hsp.GenericFramework.Dto.Models.Models
{
    public class MenuItemTypeTranslationModel : BaseEntityModel
    {
        public Guid MenuItemTypeId { get; set; }
        public string MenuItemTypeName { get; set; }
        public int LanguageId { get; set; }
    }
}
