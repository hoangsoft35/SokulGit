using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.Routing;
using Hsp.GenericFramework.Dto.Models;


namespace Hsp.GenericFramework.Commons.HandleErrors
{
    public class WebHandleErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            var model = new HandleErrorInfo(filterContext.Exception, filterContext.RequestContext.RouteData.Values["Controller"].ToString(), filterContext.RequestContext.RouteData.Values["Action"].ToString());

            filterContext.Result = new ViewResult()
            {
                ViewName = "Error",
                ViewData = new ViewDataDictionary(model)
            };
        }

    }
    
}
