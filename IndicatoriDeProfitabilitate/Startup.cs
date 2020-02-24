using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IndicatoriDeProfitabilitate.Startup))]
namespace IndicatoriDeProfitabilitate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
