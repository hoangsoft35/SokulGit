using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Commons.Dtos.Base;

namespace Hsp.GenericFramework.Commons.Dtos.Models
{
    public class ItemTranslationModel : BaseEntityModel
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Shortcut { get; set; }

    }
}
