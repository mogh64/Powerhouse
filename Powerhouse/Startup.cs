using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Powerhouse.Startup))]
namespace Powerhouse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
