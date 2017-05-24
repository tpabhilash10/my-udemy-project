using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VandanamVillas.Startup))]
namespace VandanamVillas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
