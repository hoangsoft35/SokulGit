using System;
using Hsp.GenericFramework.Dto.Models.Base;

namespace Hsp.GenericFramework.Dto.Models.Models
{
    public class MenuItemTranslationModel : BaseEntityModel
    {
        public Guid MenuItemId { get; set; }
        public string Label { get; set; }
        public int LanguageId { get; set; }
    }
}
