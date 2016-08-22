using System;
using System.Collections.Generic;
using Hsp.GenericFramework.Dto.Models;
using Hsp.GenericFramework.Dto.Models.Models;

namespace Hsp.GenericFramework.IServices.IServices
{
    public interface IMenuItemService
    {
        List<MenuItemModel> GetMenuByRole(string[] roles, int languageId);
        List<MenuItemModel> GetMenuByMenuType(int languageId, string menuItemTypeId);
        ErrorModel SaveMenuItem(MenuItemModel menuItemModel, List<MenuItemTranslationModel> menuItemTranslationModels, MenuItemTranslationModel menuItemTranslationDefaultModel);
        MenuItemModel GetMenuItemById(Guid menuItemId);
    }
}
