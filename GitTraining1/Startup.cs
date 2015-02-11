using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitTraining1.Startup))]
namespace GitTraining1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
