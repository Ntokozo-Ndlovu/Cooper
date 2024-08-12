using System.Net;
using Cooper.API.Common;

namespace Cooper.API.Response.Challenge
{
    public class FindChallengesResponse:ResponseBase
    {
 
        public FindChallengesResponse(HttpStatusCode httpStatusCode, string description):base(httpStatusCode,description){
        }
            
        public List<Common.Challenge> Challenges {get; set; }

    }
}
