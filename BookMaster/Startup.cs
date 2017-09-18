using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookMaster.Startup))]
namespace BookMaster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
