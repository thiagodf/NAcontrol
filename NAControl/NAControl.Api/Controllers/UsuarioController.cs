using Microsoft.Owin.Security;
using NAControl.Api.Models;
using NAControl.Domain.Contracts.Repositories;
using NAControl.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;


namespace NAControl.Api.Controllers
{
    [RoutePrefix("api/usuario")]
    public class UsuarioController : ApiController
    {
        private IUsuarioServico _service;
        public UsuarioController(IUsuarioServico service)
        {
            this._service = service;
        }

        [HttpPost]
        [Route("")]
        public Task<HttpResponseMessage> Post(ApiUsuario model)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                _service.Register(model.Nome, model.Email, model.Senha, model.ConfirmaSenha);
                response = Request.CreateResponse(HttpStatusCode.OK, new { name = model.Nome, email = model.Email });
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);

            return tsc.Task;
        }

        private IAuthenticationManager Authentication
        {
            get { return HttpContext.Current.GetOwinContext().Authentication; }
        }

        // GET api/me
        // A tag Authorize obriga estar autenticado para acessar o mesmo
        [Authorize]
        public string Get()
        {
            return this.Authentication.User.Identity.Name;
        }
    }
}
