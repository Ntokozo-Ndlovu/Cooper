using System.Net;
using Cooper.API.Common;

namespace Cooper.API.Response.Post
{
    public class Comment:ResponseBase
    {
        public Comment(HttpStatusCode httpStatusCode, string description):base(httpStatusCode, description){
        }

        public string Body { get; set; }

    }
}
