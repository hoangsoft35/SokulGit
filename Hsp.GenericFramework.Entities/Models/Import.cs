using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class Import : BaseEntityWithUserInformation
    {
        [Key]
        public string Id { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public string Note { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }


    }
}
