using System.Collections.Generic;
using Hsp.GenericFramework.Commons.Dtos.Models;
using Hsp.GenericFramework.Commons.Dtos;

namespace Hsp.GenericFramework.IServices.IServices
{
    public interface IMenuItemService
    {
        List<MenuItemModel> GetMenuByRole(string[] roles, int languageId);
        List<MenuItemModel> GetMenuByMenuType(int languageId, string menuItemTypeId);
        ErrorModel SaveMenuItem(MenuItemModel menuItemModel, List<MenuItemTranslationModel> menuItemTranslationModels);
    }
}
