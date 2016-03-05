using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Commons.Dtos.Base;

namespace Hsp.GenericFramework.Commons.Dtos.Models
{
    public class StatusModel : BaseEntityModel
    {
        [Key]
        public int Id { get; set; }
        public bool IsActive { get; set; }

    }
}
