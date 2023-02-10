using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectFour.Startup))]
namespace ProjectFour
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
