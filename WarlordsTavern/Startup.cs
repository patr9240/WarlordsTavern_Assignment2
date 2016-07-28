using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WarlordsTavern.Startup))]
namespace WarlordsTavern
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
