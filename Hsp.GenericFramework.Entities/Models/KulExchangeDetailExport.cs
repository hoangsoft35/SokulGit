using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class KulExchangeDetailExport : BaseEntityWithUserInformation
    {
        [Key]
        public int Id { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public decimal TotalBillFrom { get; set; }
        public decimal TotalBillTo { get; set; }
        public int KulBonusValue { get; set; }


    }
}
