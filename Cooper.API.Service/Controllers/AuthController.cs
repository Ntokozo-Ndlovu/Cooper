using System.Net;
using Cooper.API.Request.Auth;
using Cooper.API.Response.Auth;
using Cooper.API.Service.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Cooper.API.Service
{
    public class AuthController:BaseController
    {
        [HttpPost]
        [Route("login")]
        public ActionResult<LoginResponse> Login([FromBody] LoginRequest request)
        {
            try
            {
                var user = Domain.User.FindUserName(request.Username);
                var password = Domain.Password.Find(user);
                var response = new LoginResponse();

                if (!password.PasswordKey.Equals(request.Password))
                {
                    response.StatusCode = HttpStatusCode.Unauthorized;
                    response.Message = "Password Does Not Match";
                    return Ok(response.ToApiModel());
                }
                response.UserId = user.UserUUID;
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
            var address = Domain.Address.Create(request.Address.ToAddressEntity());
            var contact = Domain.Contact.Create(request.Contact.ToContactEntity());
            var person = Domain.Person.Create(request.Person.ToPersonEntity());
            var user = Domain.User.Create(request.UserName, person, address, contact);
            Domain.Password.Create(request.Password.ToPasswordEntity(),user);
            var response = new CreateUserResponse()
            {
                UserID = user.UserUUID,
                StatusCode = HttpStatusCode.Created,
            };

            return Ok(response.ToApiModel());
        }


    }
}