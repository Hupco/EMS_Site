using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserInterfaceLayer.Startup))]
namespace UserInterfaceLayer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
