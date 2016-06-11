using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Hsp.GenericFramework.Commons.Security;
using Hsp.GenericFramework.IServices.IServices;
using Hsp.GenericFramework.Web.Admin.Base;
using Hsp.GenericFramework.Commons;
using Hsp.GenericFramework.Commons.Dtos.Models;
using Hsp.GenericFramework.Services.MapperProfiles;

namespace Hsp.GenericFramework.Web.Admin.Controllers.Base
{
    public class BaseController : Controller
    {
        private readonly ILanguageService _languageService;
        private readonly IMenuItemService _menuItemService;
        private readonly ILoopkupService _loopkupService;
        private readonly IResourceService _resourceService;
        public BaseController(ILanguageService languageService, IMenuItemService menuItemService, ILoopkupService loopkupService, IResourceService resourceService)
        {
            _languageService = languageService;
            _menuItemService = menuItemService;
            _loopkupService = loopkupService;
            _resourceService = resourceService;
            LanguageId = GetDefaultLanguage();
            
        }

        public int LanguageId
        {
            get
            {
                return CurrentUser?.CurrentLanguageId ?? GetDefaultLanguage();
            }
            set
            {

            }
        }
        public UserProfileLogin CurrentUser { get; set; }
        public BaseViewModel BaseViewModel { get; set; }
        private int GetDefaultLanguage()
        {
            return _languageService.GetDefaultLanguage()?.Id ?? Consts.LangCultures.DefaultLanguage;
        }
        
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
            CurrentUser = (UserProfileLogin) Session?["HspUser"];
            if (CurrentUser != null)
            {
                // only load menu 1 time when login until logout
                if (BaseViewModel == null)
                {
                    BaseViewModel = new BaseViewModel
                    {
                        MenuItems = _menuItemService.GetMenuByRole(
                            CurrentUser.UserRoles.Select(x => x.RoleId.ToString()).ToArray(), LanguageId),
                        LanguageModels = _languageService.GetAllLanguage().Select(x=>new SelectListItem {Value = x.Id.ToString(),Text = x.DisplayName, Selected = x.IsDefault }).ToList(),
                        Breadcrumbs = new List<MenuItemModel>()
                    };

                    foreach(var item in BaseViewModel.LanguageModels)
                    {
                        if (item.Value.Equals(this.LanguageId.ToString()))
                        {
                            item.Selected = true;
                        }
                        else
                        {
                            item.Selected = false;
                        }
                    }

                }
               
            }

            

            //load loopkups value
            var loopkups = _loopkupService.LoadLoppkups();
            Consts.Loopkups.Load(loopkups);

            //load resources for current view
            string actionName = filterContext.ActionDescriptor.ActionName;
            string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string viewId = (controllerName + "_" + actionName).ToLower();
            var resources = _resourceService.LoadResources(LanguageId, viewId);
            if (BaseViewModel == null)
                BaseViewModel = new BaseViewModel();
            BaseViewModel.Resources = resources;
            TempData["BaseViewModel"] = BaseViewModel;

            //var controllerName = filterContext.RouteData.Values["controller"].ToString();
            //var actionName = filterContext.RouteData.Values["action"].ToString();
            // menu only 3 level
            // Top menu
            //----Left menu
            //--------Left child menu
            if (BaseViewModel?.MenuItems != null)
            {
                var leafNode =
                BaseViewModel.MenuItems.FirstOrDefault(x => x.ActionName == actionName && x.ControllerName == controllerName);
              
                // check level 2 left menu
                if (leafNode != null)
                {
                    leafNode.IsCurrentSelected = true;
                    var leftMenu = BaseViewModel.MenuItems.FirstOrDefault(x => x.Id == leafNode.ParentId && !x.IsRoot);
                    // check top menu
                    if (leftMenu != null)
                    {
                        var leftChildMenu = BaseViewModel.MenuItems.FirstOrDefault(x => x.Id == leftMenu.ParentId && x.IsRoot);
                        if (leftChildMenu != null)
                        {
                            BaseViewModel.Breadcrumbs.Add(leftChildMenu);
                        }
                        BaseViewModel.Breadcrumbs.Add(leftMenu);
                    }
                    BaseViewModel.Breadcrumbs.Add(leafNode);

                }

            }
            base.OnActionExecuting(filterContext);
        }

        //protected override void OnActionExecuted(ActionExecutedContext filterContext)
        //{
        //    var controllerName = filterContext.RouteData.Values["controller"].ToString();
        //    var actionName = filterContext.RouteData.Values["action"].ToString();
        //    // menu only 3 level
        //    // Top menu
        //    //----Left menu
        //    //--------Left child menu
        //    if (BaseViewModel?.MenuItems != null)
        //    {
        //        var leafNode =
        //        BaseViewModel.MenuItems.FirstOrDefault(x => x.ActionName == actionName && x.ControllerName == controllerName);

        //        // check level 2 left menu
        //        if (leafNode != null)
        //        {
        //            var leftMenu = BaseViewModel.MenuItems.FirstOrDefault(x => x.Id == leafNode.ParentId && !x.IsRoot);
        //            // check top menu
        //            if (leftMenu != null)
        //            {
        //                var leftChildMenu = BaseViewModel.MenuItems.FirstOrDefault(x => x.Id == leftMenu.ParentId && !x.IsRoot);
        //                if (leftChildMenu != null)
        //                {
        //                    BaseViewModel.Breadcrumbs.Add(leftChildMenu);
        //                }
        //                BaseViewModel.Breadcrumbs.Add(leftMenu);
        //            }
        //            BaseViewModel.Breadcrumbs.Add(leafNode);
                     
        //        }
                
        //    }

        //    base.OnActionExecuted(filterContext);
        //}
    }
}