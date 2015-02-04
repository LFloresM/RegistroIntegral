using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RegistroIntegral.Startup))]
namespace RegistroIntegral
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
