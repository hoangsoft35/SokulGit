using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class ExportDetail : BaseEntityWithUserInformation
    {
        [Key, Column(Order = 1)]
        public string ExportId { get; set; }
        public virtual Export Export { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        [Key,Column(Order = 2)]
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public float Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal ItemDiscount { get; set; }
        public bool IsItemPay { get; set; }
        public int ItemPriceId { get; set; }
        //public virtual ItemPrice ItemPrice { get; set; }
        public bool Note { get; set; }


    }
}
