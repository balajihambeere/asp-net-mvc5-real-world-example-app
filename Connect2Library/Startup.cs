using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Connect2Library.Startup))]
namespace Connect2Library
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
