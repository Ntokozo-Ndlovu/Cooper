using System.Net;

namespace Cooper.API.Response.Auth
{
    public class CreateUserResponse
    {
        public long  UserID { get; set; }
        public string Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
