using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Hsp.GenericFramwork.Api.Startup))]

namespace Hsp.GenericFramwork.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
