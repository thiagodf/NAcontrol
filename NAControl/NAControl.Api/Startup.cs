using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(NAControl.Api.Startup))]
namespace NAControl.Api
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            //TODO: Configurar Owin mais tarde
        }
    }
}