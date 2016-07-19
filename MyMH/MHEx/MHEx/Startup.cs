using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MHEx.Startup))]
namespace MHEx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
