using Hsp.GenericFramework.Commons.Dtos.Base;
using System;

namespace Hsp.GenericFramework.Commons.Dtos.Models
{
    public class MenuItemModel : BaseEntityModel
    {
        public Guid Id { get; set; }
        public bool IsRoot { get; set; }
        public bool IsActive { get; set; }
        public Guid ParentId { get; set; }
        public string Label { get; set; }
        public bool IsTitle { get; set; }
        public bool IsLink { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public int SectionParameter { get; set; }
        public int Order { get; set; }  

    }
}
