using System.Web.Http;
using Finan.Domain.Contracts.Business;

namespace Finan.WebApi.Controllers
{
    [RoutePrefix("v1/local")]
    public class LocalController : ApiController
    {
        private readonly ILocalService _localService;

        public LocalController(ILocalService localService)
        {
            _localService = localService;
        }

        [Route("get/{page:int}")]
        [HttpGet]
        public IHttpActionResult Get(int page)
        {
            return Ok(_localService.Get(0));
        }

        [Route("get/{id:int}")]
        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            return Ok(_localService.GetById(id));
        }

        [Route("create")]
        [HttpPost]
        public IHttpActionResult Create(string description, int userId)
        {
            return Ok(_localService.Create(description, userId));
        }

        [Route("changedescription")]
        [HttpPut]
        public IHttpActionResult ChangeDescription(int localId, string description)
        {
            _localService.ChangeDescription(localId, description);
            return Ok();
        }

        [Route("delete")]
        [HttpDelete]
        public IHttpActionResult Delete(int localId)
        {
            _localService.Delete(localId);
            return Ok();
        }
    }
}