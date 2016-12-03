using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClassDeclarationsThsesis.Startup))]
namespace ClassDeclarationsThsesis
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
