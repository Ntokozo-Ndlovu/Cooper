using System.Net;
using Cooper.API.Request.Auth;
using Cooper.API.Response.Auth;
using Cooper.API.Service.Extensions;
using Cooper.Data;
using Microsoft.AspNetCore.Mvc;

namespace Cooper.API.Service
{
    public class AuthController:BaseController
    {
        private readonly CooperDbContext _db;

        public AuthController(CooperDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        [Route("login")]
        public ActionResult<LoginResponse> Login([FromBody] LoginRequest request)
        {
            try
            {
                var user = Domain.User.FindUserName(request.Username,_db);
                var password = Domain.Password.FindByUserId(user.Id, _db);
                var response = new LoginResponse();

                if (!password.PasswordKey.Equals(request.Password))
                {
                    response.StatusCode = HttpStatusCode.Unauthorized;
                    response.Message = "Password Does Not Match";
                    return Ok(response.ToApiModel());
                }
                response.UserId = user.Id.ToString();
                response.StatusCode = HttpStatusCode.Found;

                return Ok(response.ToApiModel());              
                
            }
            catch(Exception ex)
            {
                var response = new LoginResponse()
                {
                    StatusCode = HttpStatusCode.NotFound,
                    Message = ex.Message
                };

                return Ok(response.ToApiModel());
            }
        }

        [HttpPost]
        [Route("register")]
        public ActionResult<CreateUserResponse> CreateUser([FromBody] CreateUserRequest request)
        {
            var address = Domain.Address.Create(request.Address.StreetName,request.Address.Suburb,request.Address.City, request.Address.PostalCode, _db);
            var contact = Domain.Contact.Create(request.Contact.Email,request.Contact.PhoneNumber, _db);          
            var person = Domain.Person.Create(request.Person.Name,request.Person.Surname,request.Person.Age, request.Person.Gender,_db);
            var user = Domain.User.Create(request.UserName, person.Id, address.Id, contact.Id,_db);
            Domain.Password.Create(request.Password.Password,user.Id, _db);
            var response = new CreateUserResponse()
            {
                UserID = user.Id.ToString(),
                StatusCode = HttpStatusCode.Created,
            };

            return Ok(response.ToApiModel());
        }


    }
}
