using System.Web.Http;
using Finan.Domain.Contracts.Business;

namespace Finan.WebApi.Controllers
{
    [RoutePrefix("v1/item")]
    public class ItemController : ApiController
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [Route("get/{page:int}")]
        [HttpGet]
        public IHttpActionResult Get(int page)
        {
            return Ok(_itemService.Get(0));
        }

        [Route("getbyid/{id:int}")]
        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            return Ok(_itemService.GetById(id));
        }

        [Route("create")]
        [HttpPost]
        public IHttpActionResult Create(decimal total, string title, string description,
            int localId, int typeId)
        {
            var userId = 1;
            return Ok(_itemService.Create(total, title, description, userId, localId, typeId));
        }

        [Route("changedetails")]
        [HttpPut]
        public IHttpActionResult ChangeDetails(int itemId, string title, string description, decimal total)
        {
            _itemService.ChangeDetails(itemId, title, description, total);
            return Ok();
        }

        [Route("delete")]
        [HttpDelete]
        public IHttpActionResult Delete(int itemId)
        {
            _itemService.Delete(itemId);
            return Ok();
        }
    }
}