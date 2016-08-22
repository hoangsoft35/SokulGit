using System.Collections.Generic;
using Hsp.GenericFramework.Dto.Models.Models;
using Hsp.GenericFramework.Web.Admin.Base;

namespace Hsp.GenericFramework.Web.Admin.ViewModels
{
    public class MenuItemCreateViewModels :BaseViewModel
    {
        public MenuItemCreateViewModels()
        {
            MenuItemModel=new MenuItemModel();
            MenuItemTranslationModels = new List<MenuItemTranslationModel>();
            DefaulTranslationModel = new MenuItemTranslationModel() {Label = ""};
            MenuItemTypes = new List<MenuItemTypeModel>();
        }
        public MenuItemModel MenuItemModel { get; set; }
        public List<MenuItemTranslationModel> MenuItemTranslationModels { get; set; }
        public MenuItemTranslationModel DefaulTranslationModel { get; set; }
        public List<MenuItemTypeModel> MenuItemTypes { get; set; }
    }
    
}
