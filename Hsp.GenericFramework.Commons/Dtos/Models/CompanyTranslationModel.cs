using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Commons.Dtos.Base;

namespace Hsp.GenericFramework.Commons.Dtos.Models
{
    public class CompanyTranslationModel : BaseEntityModel
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }


    }
}
