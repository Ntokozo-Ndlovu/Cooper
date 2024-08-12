using System.Net;
using Cooper.API.Common;

namespace Cooper.API.Response.Challenge
{
    public class ChallengeResponse : ResponseBase
    {
        public ChallengeResponse(HttpStatusCode httpStatusCode, string description) : base(httpStatusCode, description)
        {

        }
        public Common.Challenge Challange {get; set;}        
   }
}
