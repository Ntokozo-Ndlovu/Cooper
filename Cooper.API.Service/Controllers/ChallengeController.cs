using System.Net;
using Microsoft.AspNetCore.Mvc;
using Cooper.API.Request.Challenge;
using Cooper.API.Response.Challenge;
using Cooper.API.Service.Extensions;
using Cooper.Data;


namespace Cooper.API.Service.Controllers
{
    public class ChallengeController : BaseController
    {
        private readonly CooperDbContext _db;

        public ChallengeController(CooperDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        [Route("challenge")]
        public FindChallengesResponse GetAllChallenge()
        {
            List<Domain.Challenge> challenges = Domain.Challenge.FindAll(_db);
            FindChallengesResponse response = new FindChallengesResponse(HttpStatusCode.OK, "")
            {
                Challenges = challenges.DTO()
            };
            return response;
        }


        [HttpGet]
        [Route("challenge/{challengeId}")]
        public FindChallengeResponse GetChallenge(Guid challengeId)
        {
            Domain.Challenge challenge = Domain.Challenge.FindById(challengeId, _db);
            FindChallengeResponse response = new FindChallengeResponse(HttpStatusCode.OK, "")
            {
                Challenge = challenge.DTO()
            };
            return response;
        }


        [HttpPost]
        [Route("challenge")]
        public CreateChallengeResponse CreateChallenge([FromBody] CreateChallengeRequest body)
        {
            Domain.Challenge challenge = Domain.Challenge.Create(body.Name, body.Description, body.StartDate, body.EndDate, body.Price, _db);
            CreateChallengeResponse response = new CreateChallengeResponse(HttpStatusCode.OK, "")
            {
                Challenge = challenge.DTO()
            };
            return response;

        }


        [HttpPatch]
        [Route(("challenge/{challengeId}"))]
        public UpdateChallengeResponse EditChallenge(Guid challengeId, [FromBody] UpdateChallengeRequest body)
        {

            Domain.Challenge challenge = Domain.Challenge.UpdateChallenge(challengeId, _db, name: body.Name, description: body.Description,
                    startDate: body.StartDate, endDate: body.EndDate, price: body.Price);
            UpdateChallengeResponse response = new UpdateChallengeResponse(HttpStatusCode.OK, "")
            {
                Challenge = challenge.DTO()
            };
            return response;
        }


        [HttpDelete]
        [Route("challenge/{challengeId}")]
        public DeleteChallengeResponse DeleteChallenge(Guid challengeId)
        {
            Domain.Challenge challenge = Domain.Challenge.RemoveChallengeById(challengeId, _db);
            DeleteChallengeResponse response = new DeleteChallengeResponse(HttpStatusCode.OK, "")
            {
                Challenge = challenge.DTO()
            };

            return response;
        }


    }
}
