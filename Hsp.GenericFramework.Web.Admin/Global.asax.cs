using System.Configuration;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using Hsp.GenericFramework.Commons.Security;
using Hsp.GenericFramework.IServices.IServices;
using Hsp.GenericFramework.Services;
using Hsp.GenericFramework.Services.Base;
using Hsp.GenericFramework.Services.Services;

namespace Hsp.GenericFramework.Web.Admin
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Add HspSessionExpire Attribute for all action
            GlobalFilters.Filters.Add(new HspSessionExpireAttribute());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly).InstancePerLifetimeScope();
            var autofacModuleType = ConfigurationSettings.AppSettings.Get("autofacModuleType");
          
            builder.RegisterModule(new ServiceModules(autofacModuleType));

           

            var container = builder.Build();

      


            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));



        }
    }
}
