using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day3StarWars.Startup))]
namespace Day3StarWars
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
