using Hsp.GenericFramework.Dto.Models.Base;

namespace Hsp.GenericFramework.Dto.Models.Models
{
    public class ItemModel : BaseEntityModel
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public int ItemTypeId { get; set; }
        public int UnitId { get; set; }
        public bool IsDrink { get; set; }
        public string ItemTypeName { get; set; }
        public string ItemName { get; set; }
        public string Shortcut { get; set; }
        public int CurrentPriceId { get; set; }
        public decimal CurrentPriceValue { get; set; }


    }
}
