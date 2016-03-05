using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Commons.Dtos.Base;

namespace Hsp.GenericFramework.Commons.Dtos.Models
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
