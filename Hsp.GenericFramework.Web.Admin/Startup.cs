using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hsp.GenericFramework.Web.Admin.Startup))]
namespace Hsp.GenericFramework.Web.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
