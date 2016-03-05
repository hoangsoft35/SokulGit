using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class ExportGift : BaseEntityWithUserInformation
    {
        [Key]
        public string Id { get; set; }
        public string MemberCardNumber { get; set; }
        public bool IsMember { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }


    }
}
