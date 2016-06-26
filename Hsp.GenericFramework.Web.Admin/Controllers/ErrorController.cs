using System.Web.Mvc;

namespace Hsp.GenericFramework.Web.Admin.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Error()
        {

            return View();
        }
        public ActionResult AccessDenied()
        {

            ViewBag.Title = "Oops! Access Denined ";
            ViewBag.ErrorMessage = "Oops! Access Denined ";
            return View("~/Views/Error/CustomError.cshtml");
        }

        public ActionResult SessionTimeOut()
        {
            ViewBag.Title = "Oops! Session Timeout ";
            ViewBag.ErrorMessage = "Oops! Session Timeout";
            return View("~/Views/Error/CustomError.cshtml");
        }

        public ActionResult NotFound()
        {
   
            return View();
        }
        public ActionResult Forbidden()
        {
            return View();
        }
        public ActionResult InternalError()
        {

            return View();
        }
        public ActionResult UnAuthorization()
        {

            return View();
        }
    }
}