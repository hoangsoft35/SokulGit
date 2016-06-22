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
using System;
using Hsp.GenericFramework.Commons.Logging;

namespace Hsp.GenericFramework.Services.Services
{
    public class ResourceService : BaseService, IResourceService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IGenericRepository<Resource> _resourceRepository;
        
        public ResourceService(IUnitOfWork unitOfWork, IGenericRepository<Resource> loopkupRepository, ILogManager<ResourceService> logManager) : base(unitOfWork, logManager.GetLog())
        {
            _resourceRepository = loopkupRepository;
            _unitOfWork = unitOfWork;
        }

        public List<ResourceModel> LoadResources(int languageId, string viewId)
        {
            try {
                return _resourceRepository.Get(r => r.LanguageId == languageId && r.ViewId.Equals(viewId)).Select(Mapper.Map<ResourceModel>).ToList();
            }
            catch (Exception ex)
            {
                return new List<ResourceModel>();
            }
        }

    }
}