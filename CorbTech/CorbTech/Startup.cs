using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CorbTech.Startup))]
namespace CorbTech
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
