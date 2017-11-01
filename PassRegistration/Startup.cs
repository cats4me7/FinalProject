using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PassRegistration.Startup))]
namespace PassRegistration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
