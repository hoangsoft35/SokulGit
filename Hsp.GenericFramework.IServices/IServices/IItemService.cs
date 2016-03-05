using System.Collections.Generic;
using Hsp.GenericFramework.Commons.Dtos.Models;

namespace Hsp.GenericFramework.IServices.IServices
{
    public interface IItemService
    {
        List<ItemModel> ListItem(int languageId);
   
    }
}
