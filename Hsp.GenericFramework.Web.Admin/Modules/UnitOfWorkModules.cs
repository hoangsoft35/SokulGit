using Autofac;
using Hsp.GenericFramework.IUnitOfWorks;
using Hsp.GenericFramework.UnitOfWorks;

namespace Hsp.GenericFramework.Web.Admin.Modules
{
    public class UnitOfWorkModules :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().AsImplementedInterfaces().InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}