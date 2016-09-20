using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CMS.Web2.Startup))]
namespace CMS.Web2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
