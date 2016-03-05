using Autofac;
using Hsp.GenericFramework.GenericRepositories;
using Hsp.GenericFramework.IGenericRepositories;
using Module = Autofac.Module;

namespace Hsp.GenericFramework.Web.Admin.Modules
{
    public class GenericRepositoryModules :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}