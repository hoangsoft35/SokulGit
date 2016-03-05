using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class ExportGiftDetail : BaseEntityWithUserInformation
    {
        [Key]
        public string ExportGiftId { get; set; }
        public virtual ExportGift ExportGift { get; set; }

        public string GiftId { get; set; }
        public virtual Gift Gift { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public decimal PriceVnd { get; set; }
        public decimal PriceKul { get; set; }
        public int Quantity { get; set; }


    }
}
