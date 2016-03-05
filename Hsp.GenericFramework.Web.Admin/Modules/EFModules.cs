using System.Data.Entity;
using Autofac;
using Hsp.GenericFramework.Entities;
using Hsp.GenericFramework.IEntities;

namespace Hsp.GenericFramework.Web.Admin.Modules
{
    public class EFModules : Module
    {
        public EFModules()
        {
            RegisterMapper();
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new HspDbContext()).As<IHspContext>().InstancePerLifetimeScope();
            builder.RegisterType(typeof(HspDbContext)).As(typeof(DbContext)).InstancePerLifetimeScope();  
            base.Load(builder);
        }
        private void RegisterMapper()
        {
            
            //throw new System.NotImplementedException();
        }
    }
}