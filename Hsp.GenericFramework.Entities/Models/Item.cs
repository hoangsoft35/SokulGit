using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hsp.GenericFramework.Entities.Models
{
    public class Item : BaseEntity
    {
        public Item()
        {
            ItemTranslations = new List<ItemTranslation>();
        }
        [Key]
        public int Id { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public int ItemTypeId { get; set; }
        public virtual ItemType ItemType { get; set; }
        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }
        public bool IsDrink { get; set; }
        public virtual ICollection<ItemPrice> ItemPrices { get; set; }
        public virtual ICollection<ItemTranslation> ItemTranslations { get; set; }
        [NotMapped]
        public ItemPrice ItemPrice { get; set; }

    }
}
