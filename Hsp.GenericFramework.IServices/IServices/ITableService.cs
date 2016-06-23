using System.Collections.Generic;
using Hsp.GenericFramework.Dto.Models.Models;

namespace Hsp.GenericFramework.IServices.IServices
{
    public interface ITableService
    {
        List<TableTranslationModel> GetAllTableByCompany(int languageId, int companyId);
        List<TableModel> ListTableNotHaveGuestByAreaId(int areaId, int languageId);
        List<TableModel> ListTableHaveGuestByAreaId(int areaId, int languageId);
    }
}
