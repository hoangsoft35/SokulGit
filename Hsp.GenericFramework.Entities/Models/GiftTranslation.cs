using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class GiftTranslation : BaseEntityWithUserInformation
    {
        [Key]
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public int GiftId { get; set; }
        public string GiftName { get; set; }
        public string GiftDescription { get; set; }
        public virtual Gift Gift { get; set; }


    }
}
