using System.Net;
using Cooper.API.Common;

namespace Cooper.API.Response.Post
{
    public class UpdatePostResponse:ResponseBase
    {
        public UpdatePostResponse(HttpStatusCode httpStatusCode, string description):base(httpStatusCode,description){
        }
        
        public Common.Post Post{get; set;}
    }
}
