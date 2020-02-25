using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyRoommate.WebApp.Startup))]
namespace MyRoommate.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
