using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hsp.GenericFramework.Entities.Models
{
    public class AreaTranslation : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public virtual Area Area { get; set; }


    }
}
