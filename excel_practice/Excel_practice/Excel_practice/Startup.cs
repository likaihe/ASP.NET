using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Excel_practice.Startup))]
namespace Excel_practice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
