using System.Reflection;
using Autofac;
using Hsp.GenericFramework.IServices.IServices;
using Hsp.GenericFramework.Services.Services;
using Module = Autofac.Module;

namespace Hsp.GenericFramework.Web.Admin.Modules
{
    public class ServiceModules :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load("Hsp.GenericFramework.Services"))
                .Where(x => x.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}