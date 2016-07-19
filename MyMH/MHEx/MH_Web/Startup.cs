using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MH_Web.Startup))]
namespace MH_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
