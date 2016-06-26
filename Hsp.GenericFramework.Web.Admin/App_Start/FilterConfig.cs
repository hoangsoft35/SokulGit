using System.Web.Mvc;
using Hsp.GenericFramework.Commons.HandleErrors;

namespace Hsp.GenericFramework.Web.Admin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new WebHandleErrorAttribute());
        }
    }
}
