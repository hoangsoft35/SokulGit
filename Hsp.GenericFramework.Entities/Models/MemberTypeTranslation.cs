using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class MemberTypeTranslation : BaseEntityWithUserInformation
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
