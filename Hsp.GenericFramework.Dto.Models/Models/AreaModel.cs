using Hsp.GenericFramework.Dto.Models.Base;

namespace Hsp.GenericFramework.Dto.Models.Models
{
    public class AreaModel : BaseEntityModel
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public int CompanyId { get; set; }
    }
}
