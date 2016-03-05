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
using Hsp.GenericFramework.Commons;
using Hsp.GenericFramework.Commons.Dtos.ViewModels;
using Hsp.GenericFramework.Commons.Dtos;

namespace Hsp.GenericFramework.Services.Services
{
    public class MenuItemService : BaseService, IMenuItemService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<MenuItem> _menuItemRepository;
        private readonly IGenericRepository<MenuItemTranslation> _menuItemTranslationRepository;
        private readonly IGenericRepository<MenuItemAuthorisation> _menuItemAuthorisationRepository;
        public MenuItemService(IUnitOfWork unitOfWork, IGenericRepository<MenuItem> menuItemRepository, IGenericRepository<MenuItemAuthorisation> menuItemAuthorisationRepository, IGenericRepository<MenuItemTranslation> menuItemTranslationRepository) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _menuItemRepository = menuItemRepository;
            _menuItemAuthorisationRepository = menuItemAuthorisationRepository;
            _menuItemTranslationRepository = menuItemTranslationRepository;
        }
        public List<MenuItemModel> GetMenuByRole(string[] roleIds, int languageId)
        {
            var listMenuItem =
                _menuItemAuthorisationRepository.Get(x => roleIds.Contains(x.RoleId.ToString())).Select(c => c.MenuItem).OrderBy(x => x.Order)
                .Where(z => z.MenuItemTranslations.FirstOrDefault(x => x.LanguageId == languageId) != null).ToList();

            foreach (var menuItem in listMenuItem)
            {
                menuItem.MenuItemTranslations = menuItem.MenuItemTranslations.Where(x => x.LanguageId == languageId).ToList();
            }

            var itemModels =  listMenuItem.Select(Mapper.Map<MenuItemModel>).ToList();
            return itemModels;
        }

        public List<MenuItemModel> GetMenuByMenuType(int languageId, string menuItemTypeId)
        {
            //var listMenuItem =
            //    _menuItemRepository.Get(r=>r.MenuItemTypeId == new Guid(menuItemTypeId)).OrderBy(r=>r.Order)
            //    .Where(z => z.MenuItemTranslations.FirstOrDefault(x => x.LanguageId == languageId) != null).ToList();

            var listMenuItem = _menuItemTranslationRepository.Get(r => r.MenuItem.MenuItemTypeId == new Guid(menuItemTypeId)
            && r.LanguageId == languageId).ToList();
            //foreach (var menuItem in listMenuItem)
            //{
            //    var menuItemTranslations = menuItem.MenuItemTranslations.Where(x => x.LanguageId == languageId).ToList();
            //}

            var itemModels = listMenuItem.Select(Mapper.Map<MenuItemModel>).ToList();
            return itemModels;
        }

        public ErrorModel SaveMenuItem(MenuItemCreateViewModels menuItemCreateViewModels)
        {
            try {
                MenuItem menuItem = new MenuItem();
                menuItem = Mapper.Map<MenuItemCreateViewModel, MenuItem>(menuItemCreateViewModels.MenuItemCreate);
                menuItem.Id = Guid.NewGuid();
                _menuItemRepository.Add(menuItem);

                MenuItemTranslation menuItemTranslation = new MenuItemTranslation();
                menuItemTranslation = Mapper.Map<MenuItemTranslationCreateViewModel, MenuItemTranslation>(menuItemCreateViewModels.MenuItemTranslationCreate);
                menuItemTranslation.MenuItemId = menuItem.Id;
                menuItemTranslation.LanguageId = Consts.LangCultures.DefaultLanguage;
                _menuItemTranslationRepository.Add(menuItemTranslation);
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
