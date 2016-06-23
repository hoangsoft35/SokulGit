using System.Collections.Generic;
using Hsp.GenericFramework.Dto.Models.Models;

namespace Hsp.GenericFramework.Web.Admin.Base
{
    public class BaseViewModel
    {
       
        public BaseViewModel()
        {
            LanguageModel=new LanguageModel();
            LanguageModels = new List<LanguageModel>();
            MenuItems =new List<MenuItemModel>();
            
        }
        public LanguageModel LanguageModel { get; set; }
        public int CurrentLanguageId { get; set; }
        public List<LanguageModel> LanguageModels { get; set; }
        public List<MenuItemModel> MenuItems { get ; set; }
        public List<MenuItemModel> Breadcrumbs { get; set; }
        public List<ResourceModel> Resources { get; set; }

    }

}