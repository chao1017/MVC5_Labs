using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FruitShopping.Startup))]
namespace FruitShopping
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
