using System.Net;
using Cooper.API.Common;

namespace Cooper.API.Response.Auth
{
    public class CreateUserResponse: ResponseBase
    {
        public CreateUserResponse(HttpStatusCode status, String description):base(status, description){ }
 
        public long  UserID { get; set; }
    }
}
