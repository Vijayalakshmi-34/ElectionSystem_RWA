using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElectionSystem_RWA.Startup))]
namespace ElectionSystem_RWA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
