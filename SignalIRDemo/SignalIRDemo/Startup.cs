using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalIRDemo.Startup))]
namespace SignalIRDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
