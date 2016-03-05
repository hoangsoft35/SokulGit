using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class Company : BaseEntityWithUserInformation
    {
        [Key]
        public int Id { get; set; }
        public string MobileNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }

    }
}
