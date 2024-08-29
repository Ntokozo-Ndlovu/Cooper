using System.Net;
using Cooper.API.Common;

namespace Cooper.API.Response
{
    public class CreateCommentResponse : ResponseBase
    {
        public CreateCommentResponse(HttpStatusCode httpStatusCode, string description) : base(httpStatusCode, description)
        {

        }
        public Common.Comment Comment {get; set; }
    }

}
