using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RealNorthWind.Startup))]
namespace RealNorthWind
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
