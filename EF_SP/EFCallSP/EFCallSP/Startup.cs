using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFCallSP.Startup))]
namespace EFCallSP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
