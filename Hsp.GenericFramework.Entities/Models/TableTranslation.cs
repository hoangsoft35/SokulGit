using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hsp.GenericFramework.Entities.Models
{
    public class TableTranslation : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public int TableId { get; set; }
        public string TableName { get; set; }
        public virtual Table Table { get; set; }


    }
}
