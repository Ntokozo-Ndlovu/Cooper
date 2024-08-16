using Cooper.API.Common;
using System.Net;


namespace Cooper.API.Response.Auth
{
    public class LoginResponse: ResponseBase
    {
        public LoginResponse(HttpStatusCode statusCode, String description):base(statusCode, description){

        }
        public long UserId {  get; set; }
    }
}
