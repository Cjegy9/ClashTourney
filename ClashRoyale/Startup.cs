using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClashRoyale.Startup))]
namespace ClashRoyale
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
