using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Session15.Startup))]
namespace Session15
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
