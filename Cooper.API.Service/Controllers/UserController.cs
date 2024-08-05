
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
        public ActionResult<GetUserResponse> GetUser(long userId)
        {
            var user = Domain.User.FindById(userId,_db);
            var address = Domain.Address.FindById(user.AddressId,_db);
            var contact = Domain.Contact.FindById(user.ContactId, _db);
            var person = Domain.Person.FindById(user.PersonId, _db);

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
