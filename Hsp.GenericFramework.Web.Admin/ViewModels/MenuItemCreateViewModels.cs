using System.Collections.Generic;
using Hsp.GenericFramework.Commons.Dtos.Models;

namespace Hsp.GenericFramework.Web.Admin.ViewModels
{
    public class MenuItemCreateViewModels 
    {
        public MenuItemModel MenuItemModel { get; set; }
        public List<MenuItemTranslationModel> MenuItemTranslationModels { get; set; }
    }
    
}
