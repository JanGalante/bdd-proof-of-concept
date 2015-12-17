using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Spp.Bdd.Web.Startup))]
namespace Spp.Bdd.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
