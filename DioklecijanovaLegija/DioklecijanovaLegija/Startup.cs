using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DioklecijanovaLegija.Startup))]
namespace DioklecijanovaLegija
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
