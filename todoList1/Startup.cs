using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(todoList1.Startup))]
namespace todoList1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
