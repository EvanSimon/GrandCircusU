using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GrandCircusU2.Startup))]
namespace GrandCircusU2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
