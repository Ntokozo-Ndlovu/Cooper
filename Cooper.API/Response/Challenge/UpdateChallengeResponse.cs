using System.Net;
using Cooper.API.Common;

namespace Cooper.API.Response.Challenge
{
    public class UpdateChallengeResponse: ResponseBase
    {
        public UpdateChallengeResponse(HttpStatusCode httpStatus, string description) : base(httpStatus, description)
        {
        }

        public Common.Challenge Challenge { get; set;}
    }
}
