using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hsp.GenericFramework.Entities.Models
{
    public class MemberTypeTranslation : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public int MemberTypeId { get; set; }
        public string MemberTypeName { get; set; }
        public string MemberTypeDescription { get; set; }
        public virtual MemberType  MemberType{ get; set; }


    }
}
