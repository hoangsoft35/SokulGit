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
    public class TableService : BaseService, ITableService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IGenericRepository<Table> _tableRepository;
        readonly IGenericRepository<TableTranslation> _tableTranslationRepository;
        public UserProfileLogin _currentUser;
        readonly IGenericRepository<Export> _exportRepository;
        public TableService(IUnitOfWork unitOfWork, IGenericRepository<Table> tableRepository, IGenericRepository<TableTranslation> tableTranslationRepository, IGenericRepository<Export> exportRepository)
        {
            _tableRepository = tableRepository;
            _tableTranslationRepository = tableTranslationRepository;
            _unitOfWork = unitOfWork;
            _exportRepository = exportRepository;
        }


        public List<TableTranslationModel> GetAllTableByCompany(int languageId, int companyId)
        {
            var listCompany = _tableTranslationRepository.Get(x => x.Table.StatusId != (int)Consts.Status.Deleted && x.LanguageId == languageId && x.Table.Area.CompanyId == companyId).ToList();
            return listCompany.Select(Mapper.Map<TableTranslationModel>).ToList();
        }
    }
}