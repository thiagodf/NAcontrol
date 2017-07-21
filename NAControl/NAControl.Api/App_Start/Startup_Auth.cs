using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using NAControl.Api.Providers;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace NAControl.Api.App_Start
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            // Para utilizar o Header "Authorization" nas requisições
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

            // Ativar o método para gerar o OAuth Token
            app.UseOAuthAuthorizationServer(new OAuthAuthorizationServerOptions()
            {
                TokenEndpointPath = new PathString("/Token"),
                Provider = new ApplicationOAuthProvider(),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(14),
                AllowInsecureHttp = true
            });
        }
    }
}