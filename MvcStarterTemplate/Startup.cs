using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcStarterTemplate.Startup))]
namespace MvcStarterTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
