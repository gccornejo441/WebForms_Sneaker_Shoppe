using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SneakerShop.Startup))]
namespace SneakerShop
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
