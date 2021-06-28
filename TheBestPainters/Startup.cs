using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheBestPainters.Startup))]
namespace TheBestPainters
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
