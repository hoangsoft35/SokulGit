using System.Configuration;
using Autofac;
using Hsp.GenericFramework.Entities;
using Hsp.GenericFramework.IGenericRepositories;

namespace Hsp.GenericFramework.GenericRepositories
{
    public class GenericRepositoryModules :Module
    {
        string _autofacModuleType;
        public GenericRepositoryModules(string autofacModuleType)
        {
            _autofacModuleType = autofacModuleType;
        }
        protected override void Load(ContainerBuilder builder)
        {
            if (_autofacModuleType == "web")
            {
                builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            }
            else
            {
                builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).SingleInstance();
            }
           
            builder.RegisterModule(new EfModules(_autofacModuleType));
            base.Load(builder);
        }
    }
}