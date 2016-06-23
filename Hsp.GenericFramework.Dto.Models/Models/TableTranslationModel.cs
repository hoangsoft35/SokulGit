using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Dto.Models.Base;

namespace Hsp.GenericFramework.Dto.Models.Models
{
    public class TableTranslationModel : BaseEntityModel
    {
        [Key]
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public int TableId { get; set; }
        public string TableName { get; set; }
        public int AreaId { get; set; }



    }
}
