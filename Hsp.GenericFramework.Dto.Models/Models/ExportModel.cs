using System;
using Hsp.GenericFramework.Dto.Models.Base;

namespace Hsp.GenericFramework.Dto.Models.Models
{
    public class ExportModel : BaseEntityModel
    {
        public string Id { get; set; }
        public int StatusId { get; set; }
        public int TableId { get; set; }
        public decimal TableDiscount { get; set; }
        public bool IsPayAll { get; set; }
        public decimal Vat { get; set; }
        public decimal Service { get; set; }
        public DateTimeOffset DatePaid { get; set; }
        public int KulQuantity { get; set; }
        public decimal MoneyExchangeByKul { get; set; }
        public int CompanyId { get; set; }
        public string TableName { get; set; }
        public string AreaName { get; set; }
    }
}
