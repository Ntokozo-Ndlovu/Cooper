using Cooper.API.Request.User;
using Cooper.API.Response.User;
using Cooper.API.Service.Extensions;
using Cooper.Domain;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace Cooper.API.Service.Controllers
{
    [Route("/api/v1")]
    public class UserController: ControllerBase
    {
        [HttpGet]
        [Route("user/{userId}")]
        public ActionResult GetUser(Guid userId)
        {
            return Ok();
        }

        [HttpPatch]
        [Route("user/{userId}")]
        public ActionResult UpdateUser(Guid userId)
        {
            return Ok();
        }


        [HttpPost]
        [Route("user")]
        public ActionResult<CreateUserResponse> CreateUser([FromBody]CreateUserRequest request) {
            var address = Domain.Address.Create(request.Address.ToAddressEntity());
            var contact = Domain.Contact.Create(request.Contact.ToContactEntity());
            var person = Domain.Person.Create(request.Person.ToPersonEntity());
            var user = Domain.User.Create(request.UserName,person,address,contact);
      
            return Ok(user.ToApiModel());
        }
    }
}
