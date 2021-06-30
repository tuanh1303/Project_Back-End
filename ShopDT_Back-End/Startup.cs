using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopDT_Back_End.Startup))]
namespace ShopDT_Back_End
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
