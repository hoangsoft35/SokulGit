using System.Collections.Generic;
using Hsp.GenericFramework.Dto.Models.Models;

namespace Hsp.GenericFramework.Web.Admin.ViewModels
{
    public class MenuItemCreateViewModels 
    {
        public MenuItemCreateViewModels()
        {
            MenuItemModel=new MenuItemModel();
            MenuItemTranslationModels = new List<MenuItemTranslationModel>();
            DefaulTranslationModel = new MenuItemTranslationModel() {Label = ""};
        }
        public MenuItemModel MenuItemModel { get; set; }
        public List<MenuItemTranslationModel> MenuItemTranslationModels { get; set; }
        public MenuItemTranslationModel DefaulTranslationModel { get; set; }
    }
    
}
