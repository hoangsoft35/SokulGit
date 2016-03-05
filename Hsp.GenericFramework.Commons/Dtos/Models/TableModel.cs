using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Commons.Dtos.Base;

namespace Hsp.GenericFramework.Commons.Dtos.Models
{
    public class TableModel : BaseEntityModel
    {

        public int Id { get; set; }
        public int AreaId { get; set; }
        public int StatusId { get; set; }
        public string TableName { get; set; }

    }
}
