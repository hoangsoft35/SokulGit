using System;
using Hsp.GenericFramework.Dto.Models.Base;

namespace Hsp.GenericFramework.Dto.Models.Models
{
    public class CustomerModel : BaseEntityModel
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public DateTimeOffset Dob { get; set; }
        public string IdCard { get; set; }
        public string MobileNumber { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActiveCard { get; set; }
        public DateTimeOffset DateActiveCard { get; set; }
        public int KulPoint { get; set; }
        public int TotalKulPoint { get; set; }
        public int TotalLost { get; set; }
        public bool IsCustomerLock { get; set; }
        public int IsCustomMemberTypeIderLock { get; set; }
        public string MemberCardNumber { get; set; }
        public string FullName { get; set; }
    }
}
