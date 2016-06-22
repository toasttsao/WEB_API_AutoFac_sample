using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WEB_API_AutoFac.Startup))]

namespace WEB_API_AutoFac
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}