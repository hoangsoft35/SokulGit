using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hsp.GenericFramework.Entities.Models
{
    public class StatusTranslation : BaseEntity
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
