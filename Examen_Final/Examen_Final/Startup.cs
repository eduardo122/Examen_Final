using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Examen_Final.Startup))]
namespace Examen_Final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
