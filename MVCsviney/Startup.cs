using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCsviney.Startup))]
namespace MVCsviney
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
