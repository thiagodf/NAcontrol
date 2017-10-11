using NAControl.Domain.Commands.Handlers;
using NAControl.Domain.Commands.Inputs;
using NAControl.Domain.Contracts.Services;
using NAControl.Domain.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace NAControl.Web_Api.Controllers
{
    [RoutePrefix("api/group")]
    public class GroupController : ApiController
    {
        private readonly GroupCommandHandler _handler;
        private IGroupService _service;

        public GroupController(IGroupService service, GroupCommandHandler handler)
        {
            _service = service;
            _handler = handler;
        }

        [HttpGet]
        [Route("")]
        //[DeflateCompression]
        //[CacheOutput(ClientTimeSpan = 100, ServerTimeSpan = 100)] //Install-Package Strathweb.CacheOutput.WebApi2
        public Task<HttpResponseMessage> Get()
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                var result = _service.GetByRange(0, 25);
                //var result = _service.GetAll();
                response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        //Busca por Nome do Grupo
        //http://localhost:1608/api/group/consulta/grupoPorNome/e
        [HttpGet]
        //[Route("consulta/grupoPorNome/{name:alpha}")]
        [Route("consulta/groupByName/{name}")]
        public Task<HttpResponseMessage> GetByName(string name)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                var result = _service.GetByName(name);
                response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }


        [HttpPost]
        [Route("create")]
        [AllowAnonymous]
        public Task<HttpResponseMessage> Post([FromBody]RegisterGroupCommand model)
        {
            var result = _handler.Handle(model);
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
               // _service.Add(model);
                _service.Register(model.Name);
                response = Request.CreateResponse(HttpStatusCode.OK, new { name = model.Name});
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }
    }
}
