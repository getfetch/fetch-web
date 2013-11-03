using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FetchWeb.Startup))]
namespace FetchWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
