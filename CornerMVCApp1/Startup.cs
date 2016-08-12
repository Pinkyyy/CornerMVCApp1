using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CornerMVCApp1.Startup))]
namespace CornerMVCApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
