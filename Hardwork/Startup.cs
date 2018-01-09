using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hardwork.Startup))]
namespace Hardwork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
