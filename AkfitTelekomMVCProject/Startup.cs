using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AkfitTelekomMVCProject.Startup))]
namespace AkfitTelekomMVCProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
