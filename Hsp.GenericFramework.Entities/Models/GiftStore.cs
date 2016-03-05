using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hsp.GenericFramework.Entities.Models
{
    public class GiftStore : BaseEntity
    {
        [Key]
        public int GiftId { get; set; }
        public virtual Gift Gift { get; set; }
        public decimal PriceImportVnd { get; set; }
        public decimal PriceExportVnd { get; set; }
        public decimal PriceExportKul { get; set; }
        public int Quantity { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }


    }
}
