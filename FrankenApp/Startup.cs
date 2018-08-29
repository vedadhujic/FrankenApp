using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FrankenApp.Startup))]
namespace FrankenApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
