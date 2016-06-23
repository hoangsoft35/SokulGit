using System.Collections.Generic;
using Hsp.GenericFramework.Dto.Models.Models;

namespace Hsp.GenericFramework.IServices.IServices
{
    public interface IMenuItemTypeService
    {
        List<MenuItemTypeModel> GetMenuItemType(int languageId);
    }
}
