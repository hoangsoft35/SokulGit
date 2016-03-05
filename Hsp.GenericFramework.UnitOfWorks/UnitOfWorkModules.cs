using Autofac;
using Hsp.GenericFramework.IUnitOfWorks;

namespace Hsp.GenericFramework.UnitOfWorks
{
    public class UnitOfWorkModules :Module
    {
        string _autofacModuleType;

        public UnitOfWorkModules(string autofacModuleType)
        {
            _autofacModuleType = autofacModuleType;
        }
        protected override void Load(ContainerBuilder builder)
        {
            if (_autofacModuleType == "web")
            {
                builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().AsImplementedInterfaces().InstancePerLifetimeScope();
            }
            else
            {
                builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().AsImplementedInterfaces().SingleInstance();
            }
          
            base.Load(builder);
        }
    }
}