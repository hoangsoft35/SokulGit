using System;
using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class Customer : BaseEntityWithUserInformation
    {
        [Key]
        public int Id { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public DateTimeOffset Dob { get; set; }
        public string IdCard { get; set; }
        public string MobileNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string MemberCardNumber { get; set; }
        public bool IsActiveCard { get; set; }
        public DateTimeOffset DateActiveCard { get; set; }
        public int KulPoint { get; set; }
        public int TotalKulPoint { get; set; }
        public int TotalLost { get; set; }
        public bool IsCustomerLock { get; set; }
        public int IsCustomMemberTypeIderLock { get; set; }
        public virtual MemberType MemberType { get; set; }


    }
}
