using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class Status : BaseEntityWithUserInformation
    {
        [Key]
        public int Id { get; set; }
        public bool IsActive { get; set; }

    }
}
