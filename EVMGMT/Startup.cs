using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EVMGMT.Startup))]
namespace EVMGMT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
