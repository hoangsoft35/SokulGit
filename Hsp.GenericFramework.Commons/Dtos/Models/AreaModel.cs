using Hsp.GenericFramework.Commons.Dtos.Base;

namespace Hsp.GenericFramework.Commons.Dtos.Models
{
    public class AreaModel : BaseEntityModel
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public int CompanyId { get; set; }
    }
}
