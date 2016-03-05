using System;
using System.ComponentModel.DataAnnotations;
using Hsp.GenericFramework.Entities.Base;

namespace Hsp.GenericFramework.Entities.Models
{
    public class Resource:BaseEntityWithUserInformation
    {
        [Key]
        public string Id { get; set; }
        public string ViewId { get; set; }
        public int LanguageId { get; set; }
        public string Value { get; set; }       
    }
}
