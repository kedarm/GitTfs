using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitTfs.Web.Startup))]
namespace GitTfs.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
