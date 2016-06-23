using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class ItemType : BaseEntityWithUserInformation
    {
        public ItemType()
        {
            ItemTypeTranslations = new List<ItemTypeTranslation>();
        }
        [Key]
        public int Id { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<ItemTypeTranslation> ItemTypeTranslations { get; set; }

    }
}
