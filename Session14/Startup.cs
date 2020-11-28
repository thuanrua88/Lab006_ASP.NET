using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Session14.Startup))]
namespace Session14
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
