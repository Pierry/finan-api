using System.Web.Http;
using Finan.Domain.Contracts.Business;

namespace Finan.WebApi.Controllers
{
    [RoutePrefix("v1/type")]
    public class TypeController : ApiController
    {
        private readonly ITypeService _typeService;

        public TypeController(ITypeService typeService)
        {
            _typeService = typeService;
        }

        [Route("get/{page:int}")]
        [HttpGet]
        public IHttpActionResult Get(int page)
        {
            return Ok(_typeService.Get(0));
        }

        [Route("getbyid/{id:int}")]
        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            return Ok(_typeService.GetById(id));
        }

        [Route("create")]
        [HttpPost]
        public IHttpActionResult Create(string description, int userId)
        {
            return Ok(_typeService.Create(description, userId));
        }

        [Route("changedescription")]
        [HttpPut]
        public IHttpActionResult ChangeDescription(int type, string description)
        {
            _typeService.ChangeDescription(type, description);
            return Ok();
        }

        [Route("delete")]
        [HttpDelete]
        public IHttpActionResult Delete(int typeId)
        {
            _typeService.Delete(typeId);
            return Ok();
        }
    }
}