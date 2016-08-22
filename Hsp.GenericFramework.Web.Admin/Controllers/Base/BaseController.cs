using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Hsp.GenericFramework.Commons.Security;
using Hsp.GenericFramework.IServices.IServices;
using Hsp.GenericFramework.Web.Admin.Base;
using Hsp.GenericFramework.Commons;
using Hsp.GenericFramework.Dto.Models.Models;

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
            BaseViewModel = new BaseViewModel();
            
        }

        public int LanguageId
        {
            get
            {
                return Session["LanguageId"]?.GetHashCode() ?? GetDefaultLanguage();
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
            if (filterContext.ActionParameters.ContainsKey("languageId"))
            {
                if (Session["LanguageId"] != null)
                {
                    var lang = int.Parse(filterContext.ActionParameters["languageId"].ToString());
                    var sesLang = int.Parse(Session["LanguageId"].ToString());
                    if (lang != sesLang)
                    {
                        Session["LanguageId"] = lang;
                        BaseViewModel.CurrentLanguageId = lang;
                    }
                }

            }
            if (Session["LanguageId"] == null)
            {
                BaseViewModel.CurrentLanguageId = GetDefaultLanguage();
                Session["LanguageId"] = BaseViewModel.CurrentLanguageId;
            }

            CurrentUser = (UserProfileLogin) Session?["HspUser"];
            if (CurrentUser != null)
            {
                // only load menu 1 time when login until logout

                BaseViewModel.MenuItems = _menuItemService.GetMenuByRole(
                    CurrentUser.UserRoles.Select(x => x.RoleId.ToString()).ToArray(), LanguageId);
                BaseViewModel.LanguageModels = _languageService.GetAllLanguage().ToList();
                BaseViewModel.Breadcrumbs = new List<MenuItemModel>();

            }
            else
            {
                BaseViewModel.LanguageModels = _languageService.GetAllLanguage().ToList();
                BaseViewModel.Breadcrumbs = new List<MenuItemModel>();
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
                    var leftMenu = BaseViewModel.MenuItems.FirstOrDefault(x => x.Id == leafNode.ParentId && x.Id != leafNode.Id);
                    // check top menu
                    if (leftMenu != null)
                    {
                        var leftChildMenu = BaseViewModel.MenuItems.FirstOrDefault(x => x.Id == leftMenu.ParentId && x.IsRoot && x.Id != leftMenu.Id);
                        if (leftChildMenu != null)
                        {
                            // add home menu
                           // BaseViewModel.Breadcrumbs.Add(BaseViewModel.MenuItems.FirstOrDefault(x => x.ActionName == "Index" && x.ControllerName=="Home" && x.IsRoot));
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