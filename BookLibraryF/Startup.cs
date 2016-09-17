using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookLibraryF.Startup))]
namespace BookLibraryF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
