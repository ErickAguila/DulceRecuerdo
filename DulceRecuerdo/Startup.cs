using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DulceRecuerdo.Startup))]
namespace DulceRecuerdo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
