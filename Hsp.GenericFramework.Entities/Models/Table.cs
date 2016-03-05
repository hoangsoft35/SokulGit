using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hsp.GenericFramework.Entities.Models
{
    public class Table : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int AreaId { get; set; }
        public virtual Area Area { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }

        public virtual ICollection<TableTranslation> TableTranslations { get; set; } 
    }
}
