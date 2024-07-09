using System.Net;

namespace Cooper.API.Response.Auth
{
    public class CreateUserResponse
    {
        public string UserID { get; set; }
        public string Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
