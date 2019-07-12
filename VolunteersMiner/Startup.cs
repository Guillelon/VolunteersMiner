using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VolunteersMiner.Startup))]
namespace VolunteersMiner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
