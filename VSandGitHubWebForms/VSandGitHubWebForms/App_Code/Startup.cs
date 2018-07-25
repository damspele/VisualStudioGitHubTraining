using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VSandGitHubWebForms.Startup))]
namespace VSandGitHubWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
