using System.Collections.Generic;
using Hsp.GenericFramework.Commons.Dtos.Models;

namespace Hsp.GenericFramework.IServices.IServices
{
    public interface ICompanyService
    {
        List<CompanyTranslationModel> GetAllCompanyByLanguageId(int languageId);

    }
}
