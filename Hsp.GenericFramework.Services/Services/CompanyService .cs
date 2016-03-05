using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Hsp.GenericFramework.Commons;
using Hsp.GenericFramework.Commons.Dtos.Models;
using Hsp.GenericFramework.Commons.Security;
using Hsp.GenericFramework.Entities.Models;
using Hsp.GenericFramework.IGenericRepositories;
using Hsp.GenericFramework.IServices.IServices;
using Hsp.GenericFramework.IUnitOfWorks;
using Hsp.GenericFramework.Services.Base;

namespace Hsp.GenericFramework.Services.Services
{
    public class CompanyService : BaseService, ICompanyService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IGenericRepository<Company> _companyRepository;
        readonly IGenericRepository<CompanyTranslation> _companyTranslationRepository;
        public UserProfileLogin _currentUser;
        public CompanyService(IUnitOfWork unitOfWork, IGenericRepository<Company> companyRepository, IGenericRepository<CompanyTranslation> companyTranslationRepository)
        {
            _companyRepository = companyRepository;
            _companyTranslationRepository = companyTranslationRepository;
            _unitOfWork = unitOfWork;
        }


        public List<CompanyTranslationModel> GetAllCompanyByLanguageId(int languageId)
        {
            var listCompany = _companyTranslationRepository.Get(x => x.Company.StatusId != (int)Consts.Status.Deleted && x.LanguageId == languageId);
            return listCompany.Select(Mapper.Map<CompanyTranslationModel>).ToList();
        }
      

    }
}