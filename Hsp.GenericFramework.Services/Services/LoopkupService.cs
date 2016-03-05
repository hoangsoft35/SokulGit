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
    public class LoopkupService : BaseService, ILoopkupService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IGenericRepository<Loopkup> _loopkupRepository;
        
        public LoopkupService(IUnitOfWork unitOfWork, IGenericRepository<Loopkup> loopkupRepository) : base(unitOfWork)
        {
            _loopkupRepository = loopkupRepository;
            _unitOfWork = unitOfWork;
        }

        public List<LoopkupModel> LoadLoppkups()
        {            
            return _loopkupRepository.GetAll().Select(Mapper.Map<LoopkupModel>).ToList();
        }

    }
}