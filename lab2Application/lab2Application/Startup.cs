using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab2Application.Startup))]
namespace lab2Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
