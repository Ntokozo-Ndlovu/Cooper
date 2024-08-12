using System.Net;
using Cooper.API.Common;

namespace Cooper.API.Response.Challenge
{
    public class CreateChallengeResponse:ResponseBase
    {
        public CreateChallengeResponse(HttpStatusCode httpStatusCode,string description):base(httpStatusCode, description){

        }

        public Common.Challenge Challenge {get; set;}
    }
}
