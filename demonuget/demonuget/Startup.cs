using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(demonuget.Startup))]
namespace demonuget
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
