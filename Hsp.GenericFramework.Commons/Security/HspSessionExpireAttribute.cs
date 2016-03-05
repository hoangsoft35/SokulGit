using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Hsp.GenericFramework.Commons.Security
{
    public class HspSessionExpireAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
            if (
                // Ignore check session expire if it is Login page 
                filterContext.RouteData.GetRequiredString("Controller")
                    .Equals("Account", StringComparison.CurrentCultureIgnoreCase) &&
                filterContext.RouteData.GetRequiredString("Action")
                    .Equals("Login", StringComparison.CurrentCultureIgnoreCase) ||

                // Ignore if it is capcha request 
                filterContext.RouteData.GetRequiredString("Controller")
                .Equals("DefaultCaptcha", StringComparison.CurrentCultureIgnoreCase) &&
                filterContext.RouteData.GetRequiredString("Action")
                .Equals("Generate", StringComparison.CurrentCultureIgnoreCase) ||
                    filterContext.RouteData.GetRequiredString("Controller")
                .Equals("DefaultCaptcha", StringComparison.CurrentCultureIgnoreCase) &&
                filterContext.RouteData.GetRequiredString("Action")
                .Equals("Refresh", StringComparison.CurrentCultureIgnoreCase))
            {
                return;
            }

            var sessionState = HttpContext.Current.Session;
            if (sessionState != null)
            {
                if (sessionState.IsNewSession || sessionState["HspUser"] == null)
                {

                    if (filterContext.HttpContext.Request.IsAjaxRequest())
                    {
                        filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Error", Action = "SessionTimeOut" }));
                    }
                    else
                    {
                        filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary { { "Controller", "Account" }, { "Action", "Login" } });
                    }
                }
            }
            base.OnActionExecuting(filterContext);
        }
    }
}
