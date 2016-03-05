using System;
using System.ComponentModel.DataAnnotations;

namespace Hsp.GenericFramework.Entities.Models
{
    public class Loopkup:BaseEntity
    {
        [Key]
        public string Id { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }        
    }
}
