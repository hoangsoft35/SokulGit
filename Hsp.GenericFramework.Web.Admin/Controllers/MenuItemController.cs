using System;
using Hsp.GenericFramework.IServices.IServices;
using Hsp.GenericFramework.Web.Admin.Controllers.Base;
using Hsp.GenericFramework.Web.Admin.Models;
using System.Web.Mvc;
using Hsp.GenericFramework.Commons.CustomValidationAttribute;
using Hsp.GenericFramework.Dto.Models.Models;
using Hsp.GenericFramework.Web.Admin.ViewModels;

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

        [HttpPost]
        [IgnoreValidateFieldOnModel("MenuItemTranslationModels")]
        public ActionResult CreateMenuItem(MenuItemCreateViewModels menuItemCreateViewModels)
        {
            if (ModelState.IsValid)
            {
                var result = _menuItemService.SaveMenuItem(menuItemCreateViewModels.MenuItemModel, menuItemCreateViewModels.MenuItemTranslationModels, menuItemCreateViewModels.DefaulTranslationModel);
                RedirectToAction("Index");
            }
            return View("AddEditMenuItem",menuItemCreateViewModels);
        }

        public ActionResult AddEditMenuItem(string menuItemId = "", string parentId = "", string menuItemTypeId = "")
        {
            var model = new MenuItemCreateViewModels();
            model.DefaulTranslationModel.LanguageId = LanguageId;
            model.MenuItemTypes = _menuItemTypeService.GetMenuItemType(this.LanguageId);
            if (!string.IsNullOrEmpty(menuItemId))
            {
                model.MenuItemModel = _menuItemService.GetMenuItemById(new Guid(menuItemId));
            }
            return View(model);
        }
    }
}