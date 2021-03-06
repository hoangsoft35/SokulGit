﻿using System;
using System.Configuration;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using Hsp.GenericFramework.Commons.Logging;
using Hsp.GenericFramework.Commons.Security;
using Hsp.GenericFramework.Services;

namespace Hsp.GenericFramework.Web.Admin
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Add HspSessionExpire Attribute for all action
            GlobalFilters.Filters.Add(new HspSessionExpireAttribute());

            log4net.Config.XmlConfigurator.Configure();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly).InstancePerLifetimeScope();
            var autofacModuleType = ConfigurationSettings.AppSettings.Get("autofacModuleType");
          
            builder.RegisterModule(new ServiceModules(autofacModuleType));
            builder.RegisterGeneric(typeof (LogManager<>)).As(typeof (ILogManager<>)).InstancePerLifetimeScope();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
        protected void Application_Error(object sender, EventArgs e)
        {
            var exception = Server.GetLastError();
            Server.ClearError();
            Response.Redirect("/Error/Error");
        }

    }
}
