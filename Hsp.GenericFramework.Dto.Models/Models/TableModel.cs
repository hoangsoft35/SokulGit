using Hsp.GenericFramework.Dto.Models.Base;

namespace Hsp.GenericFramework.Dto.Models.Models
{
    public class TableModel : BaseEntityModel
    {

        public int Id { get; set; }
        public int AreaId { get; set; }
        public int StatusId { get; set; }
        public string TableName { get; set; }

    }
}
