using System;
using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Dto.Models.Base;

namespace Hsp.GenericFramework.Dto.Models.Models
{
    public class MenuItemTranslationModel : BaseEntityModel
    {
        public Guid MenuItemId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Label")]
        public string Label { get; set; }
        public int LanguageId { get; set; }
    }
}
