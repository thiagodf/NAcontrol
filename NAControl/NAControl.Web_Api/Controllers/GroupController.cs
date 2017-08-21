using NAControl.Domain.Contracts.Services;
using NAControl.Web_Api.Attributes;
using NAControl.Web_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace NAControl.Web_Api.Controllers
{
    [RoutePrefix("api/group")]
    public class GroupController : ApiController
    {
        private IGroupService _service;

        public GroupController(IGroupService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("")]
        [DeflateCompression]
        //[CacheOutput(ClientTimeSpan = 100, ServerTimeSpan = 100)] //Install-Package Strathweb.CacheOutput.WebApi2
        public Task<HttpResponseMessage> Get()
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                var result = _service.GetByRange(0, 25);
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

        //[HttpPost]
        //[Route("")]
        //public Task<HttpResponseMessage> Post(Group model)
        //{
        //    HttpResponseMessage response = new HttpResponseMessage();

        //    try
        //    {
        //        _service.Register(model.GroId, model.Name, model.Adress, model.MeetingList);
        //        response = Request.CreateResponse(HttpStatusCode.OK, new { name = model.Name, email = model.Email });
        //    }
        //    catch (Exception ex)
        //    {
        //        response = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
        //    }

        //    var tsc = new TaskCompletionSource<HttpResponseMessage>();
        //    tsc.SetResult(response);
        //    return tsc.Task;
        //}

    }
}
