using System.Collections.Generic;
using Hsp.GenericFramework.Dto.Models.Models;

namespace Hsp.GenericFramework.IServices.IServices
{
    public interface IResourceService
    {
        List<ResourceModel> LoadResources(int languageId, string viewId);
    }
}
