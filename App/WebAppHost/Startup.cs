using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using OwinWebApi;

[assembly: OwinStartup(typeof(WebAppHost.Startup))]

namespace WebAppHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseOwinWebApi();
        }
    }
}
