using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vydly2.Startup))]
namespace Vydly2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
