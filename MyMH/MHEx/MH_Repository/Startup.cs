using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MH_Repository.Startup))]
namespace MH_Repository
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
