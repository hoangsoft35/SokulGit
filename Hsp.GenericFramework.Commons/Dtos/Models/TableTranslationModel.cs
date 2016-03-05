using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Commons.Dtos.Base;

namespace Hsp.GenericFramework.Commons.Dtos.Models
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
