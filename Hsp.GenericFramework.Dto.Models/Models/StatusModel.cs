using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Dto.Models.Base;

namespace Hsp.GenericFramework.Dto.Models.Models
{
    public class StatusModel : BaseEntityModel
    {
        [Key]
        public int Id { get; set; }
        public bool IsActive { get; set; }

    }
}
