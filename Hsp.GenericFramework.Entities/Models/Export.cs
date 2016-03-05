using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hsp.GenericFramework.Entities.Models
{
    public class Export : BaseEntity
    {
        [Key]
        public string Id { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }

        public int TableId { get; set; }
        public virtual Table Table { get; set; }
        public decimal TableDiscount { get; set; }
        public bool IsPayAll { get; set; }
        public decimal Vat { get; set; }
        public decimal Service { get; set; }
        public DateTimeOffset DatePaid { get; set; }
        public int KulQuantity { get; set; }
        public decimal MoneyExchangeByKul { get; set; }

        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }


    }
}
