using Hsp.GenericFramework.Dto.Models.Base;

namespace Hsp.GenericFramework.Dto.Models.Models
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
