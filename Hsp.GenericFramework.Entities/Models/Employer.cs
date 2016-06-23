using System;
using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class Employer : BaseEntityWithUserInformation
    {
        [Key]
        public int Id { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public DateTimeOffset Dob { get; set; }
        public string IdCard { get; set; }
        public string MobileNumber { get; set; }
        public string PhoneNumber { get; set; }
        public DateTimeOffset DateWork { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

    }
}
