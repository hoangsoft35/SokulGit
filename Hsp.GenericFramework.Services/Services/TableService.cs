using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Hsp.GenericFramework.Commons;
using Hsp.GenericFramework.Commons.Logging;
using Hsp.GenericFramework.Commons.Security;
using Hsp.GenericFramework.Dto.Models.Models;
using Hsp.GenericFramework.Entities.Models;
using Hsp.GenericFramework.IGenericRepositories;
using Hsp.GenericFramework.IServices.IServices;
using Hsp.GenericFramework.IUnitOfWorks;
using Hsp.GenericFramework.Services.Base;

namespace Hsp.GenericFramework.Services.Services
{
    public class TableService : BaseService, ITableService
    {readonly IUnitOfWork _unitOfWork;
        readonly IGenericRepository<Table> _tableRepository;
        readonly IGenericRepository<TableTranslation> _tableTranslationRepository;
        public UserProfileLogin _currentUser;
        readonly IGenericRepository<Export> _exportRepository;
        public TableService(IUnitOfWork unitOfWork, IGenericRepository<Table> tableRepository, IGenericRepository<TableTranslation> tableTranslationRepository, IGenericRepository<Export> exportRepository, ILogManager<TableService> logManager) : base(unitOfWork, logManager.GetLog())
        {
            _tableRepository = tableRepository;
            _tableTranslationRepository = tableTranslationRepository;
            _unitOfWork = unitOfWork;
            _exportRepository = exportRepository;
        }


        public List<TableTranslationModel> GetAllTableByCompany(int languageId, int companyId)
        {
            try
            {
                            var listCompany = _tableTranslationRepository.Get(x => x.Table.StatusId != (int)Consts.Status.Deleted && x.LanguageId == languageId && x.Table.Area.CompanyId == companyId).ToList();
            return listCompany.Select(Mapper.Map<TableTranslationModel>).ToList();
            }
            catch (Exception)
            {
                
                throw;
            }

        }
        public List<TableModel> ListTableNotHaveGuestByAreaId(int areaId, int languageId)
        {
            var listHaveGuest = _exportRepository.Get(x => x.IsPayAll == false && x.Table.AreaId == areaId).Select(y => y.TableId).ToList();
            var listTable = _tableTranslationRepository.Get(x =>!listHaveGuest.Contains(x.TableId) && x.Table.AreaId == areaId)
            ;
            return listTable?.Select(Mapper.Map<TableModel>).ToList() ?? new List<TableModel>();        }
        public List<TableModel> ListTableHaveGuestByAreaId(int areaId, int languageId)
        {
            var listHaveGuest = _exportRepository.Get(x => x.IsPayAll == false && x.Table.AreaId == areaId).Select(y => y.TableId).ToList();
            var listTable = _tableTranslationRepository.Get(x => listHaveGuest.Contains(x.TableId))
            ;return listTable?.Select(Mapper.Map<TableModel>).ToList() ?? new List<TableModel>();}
    }
}