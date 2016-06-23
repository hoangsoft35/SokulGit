using System;
using System.Configuration;
using System.Windows.Forms;
using Autofac;
using CoffeeSoft.App.Service;
using Hsp.GenericFramework.Services;

namespace CoffeeSoft.App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var builder = new ContainerBuilder();
            var autofacModuleType = ConfigurationSettings.AppSettings.Get("autofacModuleType");

            builder.RegisterModule(new ServiceModules(autofacModuleType));
            builder.RegisterType<ServiceInstance>().As<IServiceInstance>();
            builder.Register(c => new frmLogin(c.Resolve<IServiceInstance>()));

            var container = builder.Build();
            common.Autofac.Container = container;
            var mainForm = container.Resolve<IServiceInstance>();

            Application.Run(new frmLogin(mainForm));
        }
    }
}
