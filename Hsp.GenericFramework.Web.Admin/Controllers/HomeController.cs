using System.Web.Mvc;
using Hsp.GenericFramework.Commons.Security;
using Hsp.GenericFramework.IServices.IServices;
using Hsp.GenericFramework.Web.Admin.Controllers.Base;

namespace Hsp.GenericFramework.Web.Admin.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILanguageService _languageService;
        private readonly IAccountService _accountService;
        private readonly IMenuItemService _menuItemService;
        public HomeController(ILanguageService languageService, IAccountService accountService, ILoopkupService loopkupService, IMenuItemService menuItemService, IResourceService resourceService) : base(languageService, menuItemService, loopkupService, resourceService)
        {
            _languageService = languageService;
            _accountService = accountService;
            _menuItemService = menuItemService;
        }
         [HspAuthorize(HspRoles = "Super user")]
        public ActionResult Index()
        {
            return View(BaseViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}