using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hsp.GenericFramework.Entities.Models
{
    public class MenuItemTranslation: BaseEntity
    {
        [Key, Column(Order = 1)]
        public Guid MenuItemId { get; set; }
        public string Label { get; set; }
        [Key, Column(Order = 2)]
        public int LanguageId { get; set; }
        public virtual MenuItem MenuItem { get; set; }
    }
}
