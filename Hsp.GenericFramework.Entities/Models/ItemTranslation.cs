using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class ItemTranslation : BaseEntityWithUserInformation
    {
        [Key]
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Shortcut { get; set; }
        public virtual Item Item { get; set; }


    }
}
