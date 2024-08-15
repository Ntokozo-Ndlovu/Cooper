using System.Net;
using Cooper.API.Common;

namespace Cooper.API.Response.Challenge
{
    public class DeleteChallengeResponse:ResponseBase
    {

        public DeleteChallengeResponse(HttpStatusCode httpStatusCode, string description):base(httpStatusCode, description){
        }

       public Common.Challenge Challenge{get; set;}
    }
}
