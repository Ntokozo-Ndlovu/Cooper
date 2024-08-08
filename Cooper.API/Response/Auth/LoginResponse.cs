using Cooper.API.Common;
using System.Net;


namespace Cooper.API.Response.Auth
{
    public class LoginResponse: ResponseBase
    {
        public LoginResponse(HttpStatusCode statusCode, String description):base(statusCode, description){

        }
        public string UserId {  get; set; }
    }
}
