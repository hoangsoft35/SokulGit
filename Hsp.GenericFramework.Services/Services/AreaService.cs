using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Hsp.GenericFramework.Commons;
using Hsp.GenericFramework.Commons.Dtos.Models;
using Hsp.GenericFramework.Commons.Logging;
using Hsp.GenericFramework.Commons.Security;
using Hsp.GenericFramework.Entities.Models;
using Hsp.GenericFramework.IGenericRepositories;
using Hsp.GenericFramework.IServices.IServices;
using Hsp.GenericFramework.IUnitOfWorks;
using Hsp.GenericFramework.Services.Base;

namespace Hsp.GenericFramework.Services.Services
{
    public class AreaService : BaseService, IAreaService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IGenericRepository<Area> _areaRepository;
        readonly IGenericRepository<AreaTranslation> _areaTranslationRepository;
        public UserProfileLogin _currentUser;
        public AreaService(IUnitOfWork unitOfWork, IGenericRepository<Area> areaRepository, IGenericRepository<AreaTranslation> areaTranslationRepository, ILogManager<AreaService> logManager) : base(unitOfWork, logManager.GetLog())
        {
            _areaRepository = areaRepository;
            _areaTranslationRepository = areaTranslationRepository;
            _unitOfWork = unitOfWork;
        }


        public List<AreaTranslationModel> GetAllAreaByCompany(int languageId, int companyId)
        {
            var listCompany = _areaTranslationRepository.Get(x => x.Area.StatusId != (int)Consts.Status.Deleted && x.LanguageId == languageId && x.Area.CompanyId == companyId);
            return listCompany.Select(Mapper.Map<AreaTranslationModel>).ToList();
        }
    }
}