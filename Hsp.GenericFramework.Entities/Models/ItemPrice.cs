using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class ItemPrice : BaseEntityWithUserInformation
    {
        [Key]
        public int Id { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public bool IsCurrentPrice { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public DateTimeOffset EffectiveFromDate { get; set; }
        public DateTimeOffset? EffectiveToDate { get; set; }
        public decimal Value { get; set; }




    }
}
