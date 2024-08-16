using Cooper.API.Common;
using System.Net;

namespace Cooper.API.Response.User
{
    public class GetUserResponse:ResponseBase
    {
        public GetUserResponse(HttpStatusCode httpStatusCode, string description):base(httpStatusCode, description){
        }

        public Common.User User{get; set;}
    }
}
