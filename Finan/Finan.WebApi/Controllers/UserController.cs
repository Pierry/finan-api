using System;
using System.Web.Http;
using Finan.Domain.Contracts.Business;

namespace Finan.WebApi.Controllers
{
    [RoutePrefix("v1/user")]
    public class UserController : ApiController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [Route("get/{page:int}")]
        [HttpGet]
        public IHttpActionResult Get(int page)
        {
            return Ok(_userService.Get(0));
        }

        [Route("getbyid/{id:int}")]
        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            return Ok(_userService.GetById(id));
        }

        [Route("create")]
        [HttpPost]
        public IHttpActionResult Create(string email, string password, string confirmPassword)
        {
            return Ok(_userService.Create(email, password, confirmPassword));
        }

        [Route("resetpassword")]
        [HttpPost]
        public IHttpActionResult ResetPasssword(string oldPassword, string newPassword, string confirmPassword)
        {
            var userId = 1;
            _userService.ResetPassword(userId, oldPassword, newPassword, confirmPassword);
            return Ok();
        }

        [Route("updatelogon")]
        [HttpPut]
        public IHttpActionResult UpdateLogOn(DateTime lastDate)
        {
            var userId = 1;
            _userService.UpdateLogOn(userId, lastDate);
            return Ok();
        }

        [Route("changestatus")]
        [HttpDelete]
        public IHttpActionResult ChangeStatus()
        {
            var userId = 1;
            _userService.ChangeStatus(userId);
            return Ok();
        }
    }
}