using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestASPWeb.Startup))]
namespace TestASPWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
