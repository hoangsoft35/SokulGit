using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hsp.GenericFramework.Commons.Dtos.Models;
using Hsp.GenericFramework.Commons.Dtos;
using Hsp.GenericFramework.Commons.Dtos.ViewModels;

namespace Hsp.GenericFramework.IServices.IServices
{
    public interface IMenuItemService
    {
        List<MenuItemModel> GetMenuByRole(string[] roles, int languageId);
        List<MenuItemModel> GetMenuByMenuType(int languageId, string menuItemTypeId);
        ErrorModel SaveMenuItem(MenuItemCreateViewModels menuItemCreateViewModels);
    }
}
