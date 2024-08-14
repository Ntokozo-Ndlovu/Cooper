using System.Net;
using Cooper.API.Common;

namespace Cooper.API.Response.Post
{
    public class LikePostResponse : ResponseBase
    {
        public LikePostResponse(HttpStatusCode httpStatusCode, string description) : base(httpStatusCode, description)
        {
        }
        public Like Like { get; set; }

    }
}
