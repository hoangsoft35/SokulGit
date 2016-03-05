using Hsp.GenericFramework.Commons.Dtos.Base;

namespace Hsp.GenericFramework.Commons.Dtos.Models
{
    public class ExportDetailModel : ExportModel
    {
        public string ExportId { get; set; }
        public int StatusId { get; set; }
        public int ItemId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? ItemDiscount { get; set; }
        public bool IsItemPay { get; set; }
        public int ItemPriceId { get; set; }
        public bool? Note { get; set; }
        public string ItemName { get; set; }
        public double? Total { get; set; }
        public int Stt { get; set; }


    }
}
