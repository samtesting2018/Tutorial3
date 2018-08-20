using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GettingStartedClient.Startup))]
namespace GettingStartedClient
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
