using Hsp.GenericFramework.Commons.Dtos.Base;

namespace Hsp.GenericFramework.Commons.Dtos.Models
{
    public class ItemTypeTranslationModel : BaseEntityModel
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public int ItemTypeId { get; set; }
        public string ItemTypeName { get; set; }

    }
}
