using System.Collections.Generic;
using Hsp.GenericFramework.Commons.Dtos.Models;

namespace Hsp.GenericFramework.IServices.IServices
{
    public interface ITableService
    {
        List<TableTranslationModel> GetAllTableByCompany(int languageId, int companyId);
    }
}
