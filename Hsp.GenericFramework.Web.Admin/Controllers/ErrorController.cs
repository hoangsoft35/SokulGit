using System.Web.Mvc;

namespace Hsp.GenericFramework.Web.Admin.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult AccessDenied()
        {
            ViewBag.Title = "Access Denined ";
            ViewBag.Content = " An error occurred while processing your request.";
            return View("~/Views/Error/CustomError.cshtml");
        }

        public ActionResult SessionTimeOut()
        {
            ViewBag.Title = "Session Timeout ";
            ViewBag.Content = " An error occurred while processing your request.";
            return View("~/Views/Error/CustomError.cshtml");
        }
    }
}