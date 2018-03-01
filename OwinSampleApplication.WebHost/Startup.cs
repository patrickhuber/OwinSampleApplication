using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OwinSampleApplication.WebHost.Startup))]
namespace OwinSampleApplication.WebHost
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
