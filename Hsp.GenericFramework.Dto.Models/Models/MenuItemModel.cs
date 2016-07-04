using System;
using System.ComponentModel.DataAnnotations;

namespace Hsp.GenericFramework.Dto.Models.Models
{
    public class MenuItemModel 
    {
        public Guid Id { get; set; }
        public bool IsRoot { get; set; }
        public bool IsActive { get; set; }
        public Guid ParentId { get; set; }
        public string Label { get; set; }
        public bool IsTitle { get; set; }
        public bool IsLink { get; set; }
        [Required(AllowEmptyStrings = false,ErrorMessage = "Please enter Controller Name")]
        public string ControllerName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Action Name")]
        public string ActionName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Section Parameter")]
        public int SectionParameter { get; set; }
        [Range(0, 100, ErrorMessage = "Please enter valid Order number (0 - 100)")]
        public int Order { get; set; }  
        public string CssClassIcon { get; set; }  
        public bool IsCurrentSelected { get; set; }  
        public Guid MenuItemTypeId { get; set; }  

    }
}
