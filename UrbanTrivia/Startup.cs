using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UrbanTrivia.Startup))]
namespace UrbanTrivia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
