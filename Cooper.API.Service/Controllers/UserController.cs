using System.Net;
using Cooper.API.Response.User;
using Cooper.API.Service.Extensions;
using Cooper.Data;
using Microsoft.AspNetCore.Mvc;

namespace Cooper.API.Service.Controllers
{
    [Route("/api/v1")]
    public class UserController: ControllerBase
    {
        private readonly CooperDbContext _db;

        public UserController(CooperDbContext _db) {
            this._db = _db;
        }

        [HttpGet]
        [Route("user/{userId}")]
        public GetUserResponse GetUser(long userId)
        {
            Domain.User user = Domain.User.FindById(userId,_db);
            Domain.Address address = Domain.Address.FindById(user.AddressId,_db);
            Domain.Contact contact = Domain.Contact.FindById(user.ContactId, _db);
            Domain.Person person = Domain.Person.FindById(user.PersonId, _db);
            GetUserResponse response = new GetUserResponse(HttpStatusCode.OK, ""){
                User = user.DTO(address,contact,person)
            };
            return response;
        }

        [HttpPatch]
        [Route("user/{userId}")]
        public ActionResult UpdateUser(Guid userId)
        {
            return Ok();
        }


    }
}
