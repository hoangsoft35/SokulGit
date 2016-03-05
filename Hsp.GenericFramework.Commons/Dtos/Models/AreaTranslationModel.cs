using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Commons.Dtos.Base;

namespace Hsp.GenericFramework.Commons.Dtos.Models
{
    public class AreaTranslationModel : BaseEntityModel
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public int AreaId { get; set; }
        public string AreaName { get; set; }


    }
}
