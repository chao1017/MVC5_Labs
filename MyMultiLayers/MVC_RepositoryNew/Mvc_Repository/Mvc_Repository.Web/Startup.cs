using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc_Repository.Web.Startup))]
namespace Mvc_Repository.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
