using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(metanit_football.Startup))]
namespace metanit_football
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
