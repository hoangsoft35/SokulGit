using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Commons.Dtos.Base;

namespace Hsp.GenericFramework.Commons.Dtos.Models
{
    public class UnitTranslationModel : BaseEntityModel
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public int UnitId { get; set; }
        public string UnitName { get; set; }


    }
}
