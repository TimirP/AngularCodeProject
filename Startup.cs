using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularCodeProject.Startup))]
namespace AngularCodeProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
