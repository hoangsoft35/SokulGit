using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class StatusTranslation : BaseEntityWithUserInformation
    {
        [Key]
        public int Id { get; set; }
        public int StatusId { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }
        public virtual Language Language { get; set; }
        public virtual Status Status { get; set; }
    }
}
