using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class WageFeeTranslation : BaseEntityWithUserInformation
    {
        [Key]
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public int WageFeeId { get; set; }
        public string WageFeeName { get; set; }
        public string WageFeeDescription { get; set; }
        public virtual WageFee WageFee { get; set; }


    }
}
