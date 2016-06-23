using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Hsp.GenericFramework.Entities.Models;
using Hsp.GenericFramework.IGenericRepositories;
using Hsp.GenericFramework.IServices.IServices;
using Hsp.GenericFramework.IUnitOfWorks;
using Hsp.GenericFramework.Services.Base;
using System;
using Hsp.GenericFramework.Commons;
using Hsp.GenericFramework.Commons.Logging;
using Hsp.GenericFramework.Dto.Models;
using Hsp.GenericFramework.Dto.Models.Models;
using MenuItem = Hsp.GenericFramework.Entities.Models.MenuItem;

namespace Hsp.GenericFramework.Services.Services
{
    public class MenuItemService : BaseService, IMenuItemService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<MenuItem> _menuItemRepository;
        private readonly IGenericRepository<MenuItemTranslation> _menuItemTranslationRepository;
        private readonly IGenericRepository<MenuItemAuthorisation> _menuItemAuthorisationRepository;
        public MenuItemService(IUnitOfWork unitOfWork, IGenericRepository<MenuItem> menuItemRepository, IGenericRepository<MenuItemAuthorisation> menuItemAuthorisationRepository, IGenericRepository<MenuItemTranslation> menuItemTranslationRepository, ILogManager<MenuItemService> logManager) : base(unitOfWork, logManager.GetLog())
        {
            _unitOfWork = unitOfWork;
            _menuItemRepository = menuItemRepository;
            _menuItemAuthorisationRepository = menuItemAuthorisationRepository;
            _menuItemTranslationRepository = menuItemTranslationRepository;
        }
        public List<MenuItemModel> GetMenuByRole(string[] roleIds, int languageId)
        {
            var listMenuItem =
                _menuItemAuthorisationRepository.Get(x => roleIds.Contains(x.RoleId.ToString()))
                    .Select(c => c.MenuItemId);

            var menuTranslations = _menuItemTranslationRepository.Get(x => listMenuItem.Contains(x.MenuItemId) && x.LanguageId == languageId).OrderBy(x => x.Label).Select(Mapper.Map<MenuItemModel>).ToList();
            return menuTranslations;
        }

        public List<MenuItemModel> GetMenuByMenuType(int languageId, string menuItemTypeId)
        {
            //var listMenuItem =
            //    _menuItemRepository.Get(r=>r.MenuItemTypeId == new Guid(menuItemTypeId)).OrderBy(r=>r.Order)
            //    .Where(z => z.MenuItemTranslations.FirstOrDefault(x => x.LanguageId == languageId) != null).ToList();

            var listMenuItem = _menuItemTranslationRepository.Get(r => r.MenuItem.MenuItemTypeId == new Guid(menuItemTypeId)
            && r.LanguageId == languageId).OrderByDescending(x=>x.Label).ToList();
            //foreach (var menuItem in listMenuItem)
            //{
            //    var menuItemTranslations = menuItem.MenuItemTranslations.Where(x => x.LanguageId == languageId).ToList();
            //}

            var itemModels = listMenuItem.Select(Mapper.Map<MenuItemModel>).ToList();
            return itemModels;
        }

        public ErrorModel SaveMenuItem(MenuItemModel menuItemModel, List<MenuItemTranslationModel> menuItemTranslationModels)
        {
            try {

                MenuItem menuItem = new MenuItem();
                menuItem = Mapper.Map<MenuItemModel, MenuItem>(menuItemModel);
                menuItem.Id = Guid.NewGuid();
                _menuItemRepository.Add(menuItem);

                
                foreach (var tran in menuItemTranslationModels)
                {
                    var menuItemTranslation = new MenuItemTranslation();
                    menuItemTranslation = Mapper.Map<MenuItemTranslationModel, MenuItemTranslation>(tran);
                    menuItemTranslation.MenuItemId = menuItem.Id;
                    menuItemTranslation.LanguageId = tran.LanguageId;
                    _menuItemTranslationRepository.Add(menuItemTranslation);
                }
                
                _unitOfWork.SaveChanges();
                return new ErrorModel();
            }
            catch(Exception ex)
            {
                return new ErrorModel() { Code = Consts.ErrorStatus.Error, Message = ex.Message };
            }            
        }
    }
}
