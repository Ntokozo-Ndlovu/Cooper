using System.Net;
using Cooper.API.Common;

namespace Cooper.API.Response.Post
{
    public class CreatePostResponse:ResponseBase
    {

        public CreatePostResponse(HttpStatusCode httpStatusCode, string description):base(httpStatusCode,description){
        }
    }
}
