using System.Collections.Generic;
using Hsp.GenericFramework.Commons.Dtos.Models;

namespace Hsp.GenericFramework.IServices.IServices
{
    public interface IAreaService
    {
        List<AreaTranslationModel> GetAllAreaByCompany(int languageId, int companyId);
    }
}
