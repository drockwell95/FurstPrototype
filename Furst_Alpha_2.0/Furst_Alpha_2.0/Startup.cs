using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Furst_Alpha_2._0.Startup))]
namespace Furst_Alpha_2._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
