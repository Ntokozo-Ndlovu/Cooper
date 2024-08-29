using System.Net;
using Cooper.API.Common;


namespace Cooper.API.Response
{

    public class FetchCommentListResponse : ResponseBase
    {
        public FetchCommentListResponse(HttpStatusCode httpStatusCode, string description) : base(httpStatusCode, description) { }
     
        public List<Common.Comment> Comments {get; set;}
    }
}
