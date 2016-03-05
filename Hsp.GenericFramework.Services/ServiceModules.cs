using System.Reflection;
using Autofac;
using Hsp.GenericFramework.GenericRepositories;
using Hsp.GenericFramework.Services.MapperProfiles;
using Hsp.GenericFramework.UnitOfWorks;
using System.Web;
using Hsp.GenericFramework.Commons.Security;
using Hsp.GenericFramework.IServices.IServices;
using Hsp.GenericFramework.Services.Base;
using Module = Autofac.Module;


namespace Hsp.GenericFramework.Services
{
    public class ServiceModules :Module
    {
        string _autofacModuleType;
        public ServiceModules(string autofacModuleType)
        {
            _autofacModuleType = autofacModuleType;
            RegisterMapper();
        }
        protected override void Load(ContainerBuilder builder)
        {
          
            if (_autofacModuleType == "web"){
                builder.RegisterAssemblyTypes(Assembly.Load("Hsp.GenericFramework.Services"))
                .Where(x => x.Name.EndsWith("Service")).InstancePerLifetimeScope().AsImplementedInterfaces();
            }
            else
            {
                builder.RegisterAssemblyTypes(Assembly.Load("Hsp.GenericFramework.Services"))
                .Where(x => x.Name.EndsWith("Service")).SingleInstance().AsImplementedInterfaces();
            }
            builder.RegisterModule(new UnitOfWorkModules(_autofacModuleType));
            builder.RegisterModule(new GenericRepositoryModules(_autofacModuleType));
            base.Load(builder);
        }

        private void RegisterMapper()
        {
            InitializeMapper.LoadProfileMapper();
        }
    }
}