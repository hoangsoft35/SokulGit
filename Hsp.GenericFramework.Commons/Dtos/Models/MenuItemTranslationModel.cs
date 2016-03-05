using System;
using Hsp.GenericFramework.Commons.Dtos.Base;

namespace Hsp.GenericFramework.Commons.Dtos.Models
{
    public class MenuItemTranslationModel : BaseEntityModel
    {
        public Guid MenuItemId { get; set; }
        public string Label { get; set; }
        public int LanguageId { get; set; }
    }
}
