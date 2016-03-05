using System.Collections.Generic;
using Hsp.GenericFramework.Commons.Dtos.Models;

namespace Hsp.GenericFramework.IServices.IServices
{
    public interface ILanguageService
    {
        bool AddLanguage(LanguageModel model);
        List<LanguageModel> GetAllLanguage();
        bool UpdateLanguage(LanguageModel model);
        bool DeleteLanguage(LanguageModel model);
        LanguageModel GetDefaultLanguage();
    }
}
