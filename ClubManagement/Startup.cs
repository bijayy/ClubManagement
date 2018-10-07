using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClubManagement.Startup))]
namespace ClubManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
