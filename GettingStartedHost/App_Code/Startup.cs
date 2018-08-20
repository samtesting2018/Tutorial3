using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GettingStartedHost.Startup))]
namespace GettingStartedHost
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
