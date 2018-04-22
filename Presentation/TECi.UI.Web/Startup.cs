using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TECi.UI.Web.Startup))]
namespace TECi.UI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
