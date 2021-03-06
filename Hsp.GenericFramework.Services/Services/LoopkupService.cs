﻿using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Hsp.GenericFramework.Commons.Logging;
using Hsp.GenericFramework.Dto.Models.Models;
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
        
        public LoopkupService(IUnitOfWork unitOfWork, IGenericRepository<Loopkup> loopkupRepository, ILogManager<LoopkupService> logManager) : base(unitOfWork, logManager.GetLog())
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