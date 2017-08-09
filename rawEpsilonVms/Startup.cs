using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rawEpsilonVms.Startup))]
namespace rawEpsilonVms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
