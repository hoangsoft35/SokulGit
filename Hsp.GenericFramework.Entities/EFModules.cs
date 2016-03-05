using System.Data.Entity;
using Autofac;

namespace Hsp.GenericFramework.Entities
{
    public class EfModules : Module
    {
        string _autofacModuleType;
        public EfModules(string autofacModuleType)
        {
            _autofacModuleType = autofacModuleType;
            RegisterMapper();
        }

        protected override void Load(ContainerBuilder builder)
        {
            
            if (_autofacModuleType == "web")
            {
                builder.RegisterType(typeof(HspDbContext)).As(typeof(DbContext)).InstancePerLifetimeScope();
            }
            else
            {builder.RegisterType(typeof(HspDbContext)).As(typeof(DbContext)).SingleInstance();
            }
            base.Load(builder);
        }
        private void RegisterMapper()
        {
            
            //throw new System.NotImplementedException();
        }
    }
}