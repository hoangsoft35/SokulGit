using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class Loopkup:BaseEntityWithUserInformation
    {
        [Key]
        public string Id { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }        
    }
}
