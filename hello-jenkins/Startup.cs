using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hello_jenkins.Startup))]
namespace hello_jenkins
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
