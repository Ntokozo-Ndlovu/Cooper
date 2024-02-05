
using Cooper.API.Service.Extensions;
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
            var user = Domain.User.FindByUserUUID(userId);
            var address = Domain.Address.FindByEntityId(user.AddressId);
            var contact = Domain.Contact.FindEntityById(user.ContactId);
            var person = Domain.Person.FindPersonById(user.PersonId);

            return Ok(user.ToApiModel(address,contact,person));
        }

        [HttpPatch]
        [Route("user/{userId}")]
        public ActionResult UpdateUser(Guid userId)
        {
            return Ok();
        }


    }
}
