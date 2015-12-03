using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Petshopmvc.Startup))]
namespace Petshopmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
