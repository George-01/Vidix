using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidix.Startup))]
namespace Vidix
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
