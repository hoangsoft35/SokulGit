using System;
using System.ComponentModel.DataAnnotations;

namespace Hsp.GenericFramework.Entities.Models
{
    public class Resource:BaseEntity
    {
        [Key]
        public string Id { get; set; }
        public string ViewId { get; set; }
        public int LanguageId { get; set; }
        public string Value { get; set; }       
    }
}
