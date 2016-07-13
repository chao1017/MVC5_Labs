using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KendoUIWeb.Startup))]
namespace KendoUIWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
