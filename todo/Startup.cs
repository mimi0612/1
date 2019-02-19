using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(todo.Startup))]
namespace todo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
