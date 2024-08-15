using System.Net;
using Cooper.API.Common;

namespace Cooper.API.Response.Post
{
    public class FindPostsResponse:ResponseBase
    {
        public FindPostsResponse(HttpStatusCode httpStatusCode, string description):base(httpStatusCode,description){
        }
        public List<Common.Post> Posts {get; set;}
     }
}
