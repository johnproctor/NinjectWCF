using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WCFNinjectCSharp.Startup))]
namespace WCFNinjectCSharp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
