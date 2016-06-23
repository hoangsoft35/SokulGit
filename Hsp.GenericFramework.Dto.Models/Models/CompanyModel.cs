using Hsp.GenericFramework.Dto.Models.Base;

namespace Hsp.GenericFramework.Dto.Models.Models
{
    public class CompanyModel : BaseEntityModel
    {
        public int Id { get; set; }
        public string MobileNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public int StatusId { get; set; }
        

    }
}
