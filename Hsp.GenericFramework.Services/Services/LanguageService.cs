using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Hsp.GenericFramework.Commons.Dtos.Models;
using Hsp.GenericFramework.Commons.Security;
using Hsp.GenericFramework.Entities.Models;
using Hsp.GenericFramework.IGenericRepositories;
using Hsp.GenericFramework.IServices.IServices;
using Hsp.GenericFramework.IUnitOfWorks;
using Hsp.GenericFramework.Services.Base;

namespace Hsp.GenericFramework.Services.Services
{
    public class LanguageService : BaseService, ILanguageService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IGenericRepository<Language> _languageRepository;
        public UserProfileLogin _currentUser;
        public LanguageService(IUnitOfWork unitOfWork, IGenericRepository<Language> languageRepository) : base(unitOfWork)
        {
            _languageRepository = languageRepository;
            _unitOfWork = unitOfWork;
        }

        public bool AddLanguage(LanguageModel model)
        {
            var entity = Mapper.Map<Language>(model);
            _languageRepository.Add(entity);
            return _unitOfWork.SaveChanges() > 0;
        }
        public List<LanguageModel> GetAllLanguage()
        {
            var listLanguage = _languageRepository.Get(x => x.IsActive);
            return listLanguage.Select(Mapper.Map<LanguageModel>).ToList();
        }
        public bool UpdateLanguage(LanguageModel model)
        {
            var entity = Mapper.Map<Language>(model);
            _languageRepository.Update(entity);
            return _unitOfWork.SaveChanges() > 0;
        }
        public bool DeleteLanguage(LanguageModel model)
        {
            var entity = Mapper.Map<Language>(model);
            entity.IsActive = false;
            _languageRepository.Update(entity);
            return _unitOfWork.SaveChanges() > 0;
        }

        public LanguageModel GetDefaultLanguage()
        {
            var defaultLanguage = _languageRepository.Get(x => x.IsActive && x.IsDefault).FirstOrDefault();
            return Mapper.Map<LanguageModel>(defaultLanguage);
        }

    }
}