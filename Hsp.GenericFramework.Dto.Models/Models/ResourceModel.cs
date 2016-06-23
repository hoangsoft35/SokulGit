using Hsp.GenericFramework.Dto.Models.Base;

namespace Hsp.GenericFramework.Dto.Models.Models
{
    public class ResourceModel : BaseEntityModel
    {
        public string Id { get; set; }
        public string ViewId { get; set; }
        public int LanguageId { get; set; }
        public string Value { get; set; }        

    }
}
