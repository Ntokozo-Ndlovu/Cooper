using System.Net;
using Cooper.API.Common;

namespace Cooper.API.Response.Post {
    public class LikeCountForPostResponse:ResponseBase {
        public LikeCountForPostResponse(HttpStatusCode httpStatusCode, string description):base(httpStatusCode,description){}
        public Common.Like Likes {get; set;}
           }
}
