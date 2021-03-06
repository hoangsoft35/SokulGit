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
    public class MenuItemTypeService : BaseService, IMenuItemTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<MenuItemType> _menuItemTypeRepository;
        private readonly IGenericRepository<MenuItemAuthorisation> _menuItemAuthorisationRepository;
        public MenuItemTypeService(IUnitOfWork unitOfWork, IGenericRepository<MenuItemType> menuItemTypeRepository, IGenericRepository<MenuItemAuthorisation> menuItemAuthorisationRepository, ILogManager<MenuItemTypeService> logManager) : base(unitOfWork, logManager.GetLog())
        {
            _unitOfWork = unitOfWork;
            _menuItemTypeRepository = menuItemTypeRepository;
            _menuItemAuthorisationRepository = menuItemAuthorisationRepository;
        }
        public List<MenuItemTypeModel> GetMenuItemType(int languageId)
        {
            var listMenuItemType = _menuItemTypeRepository.GetAll().ToList();

            foreach (var menuItemType in listMenuItemType)
            {
                menuItemType.MenuItemTypeTranslations = menuItemType.MenuItemTypeTranslations.Where(x => x.LanguageId == languageId).ToList();
            }

            var itemModels = listMenuItemType.Select(Mapper.Map<MenuItemTypeModel>).ToList();
            return itemModels;
        }
    }
}
