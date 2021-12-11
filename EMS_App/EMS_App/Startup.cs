using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EMS_App.Startup))]
namespace EMS_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
