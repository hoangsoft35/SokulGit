﻿using Hsp.GenericFramework.IServices.IServices;
using Hsp.GenericFramework.Web.Admin.Controllers.Base;
using Hsp.GenericFramework.Web.Admin.Models;
using System.Web.Mvc;

namespace Hsp.GenericFramework.Web.Admin.Controllers
{
    public class MenuItemController : BaseController
    {
        private readonly ILanguageService _languageService;
        private readonly IAccountService _accountService;
        private readonly IMenuItemService _menuItemService;
        private readonly IMenuItemTypeService _menuItemTypeService;
        public MenuItemController(ILanguageService languageService, IAccountService accountService, ILoopkupService loopkupService, IMenuItemService menuItemService, IResourceService resourceService, IMenuItemTypeService menuItemType) : base(languageService, menuItemService, loopkupService, resourceService)
        {
            _languageService = languageService;
            _accountService = accountService;
            _menuItemService = menuItemService;
            _menuItemTypeService = menuItemType;
        }

        // GET: MenuItem
        public ActionResult Index()
        {
            MenuItemViewModels menuItemViewModels = new MenuItemViewModels();
            menuItemViewModels.MenuItemTypes = _menuItemTypeService.GetMenuItemType(this.LanguageId);
            return View(menuItemViewModels);
        }
        public JsonResult GetMenuByMenuType(string menuItemTypeId)
        {            
            var menuItems = _menuItemService.GetMenuByMenuType(this.LanguageId, menuItemTypeId);
            return Json(menuItems, JsonRequestBehavior.AllowGet);
        }
    }
}