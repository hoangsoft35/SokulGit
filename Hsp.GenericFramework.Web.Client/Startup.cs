using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hsp.GenericFramework.Web.Client.Startup))]
namespace Hsp.GenericFramework.Web.Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
