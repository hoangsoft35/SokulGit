using System;

namespace Hsp.GenericFramework.Commons.Dtos.ViewModels
{
    public class MenuItemCreateViewModels 
    {
        public MenuItemCreateViewModel MenuItemCreate { get; set; }
        public MenuItemTranslationCreateViewModel MenuItemTranslationCreate { get; set; }

    }
    public class MenuItemCreateViewModel
    {
        public Guid Id { get; set; }
        public Guid MenuItemTypeId { get; set; }
        public bool IsRoot { get; set; }
        public bool IsActive { get; set; }
        public Guid ParentId { get; set; }
        public bool IsTitle { get; set; }
        public bool IsLink { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public int SectionParameter { get; set; }
        public int Order { get; set; }

    }
    public class MenuItemTranslationCreateViewModel
    {
        public Guid MenuItemId { get; set; }
        public string Label { get; set; }        
        public int LanguageId { get; set; }

    }
}
