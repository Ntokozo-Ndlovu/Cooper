using Cooper.API.Request.Challenge;
using Cooper.API.Response.Challenge;
using Cooper.API.Service.Extensions;
using Cooper.Data;
using Cooper.Data.Entity;
using Cooper.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Cooper.API.Service.Controllers
{
    public class ChallengeController: BaseController
    {


        public ChallengeController(CooperDbContext db) {
            _ = new Domain.Challenge(db);
        }
        [HttpGet]
        [Route("challenge")]
        public ActionResult<List<FindChallengeResponse>> GetAllChallenge()
        {
            List<Data.Entity.Challenge> challenges =  Domain.Challenge.GetAllChallenges();
            List<FindChallengeResponse> result = new List<FindChallengeResponse>();
            challenges.ForEach(challenge => result.Add(challenge.ToApiModel()));
            return Ok(result);
        }


        [HttpGet]
        [Route("challenge/{challengeId}")]
        public ActionResult<FindChallengeResponse> GetChallenge(Guid challengeId)
        {
            var challenge = Domain.Challenge.FindChallengeById(challengeId);
            var result = new FindChallengeResponse()
            {
                Description = challenge.Description,
                Title = challenge.Name
            };
            return Ok(result);
        }


        [HttpPost]
        [Route("challenge")]
        public ActionResult<CreateChallengeResponse> CreateChallenge([FromBody] CreateChallengeRequest body)
        {
            var resutlt = Domain.Challenge.Add(new Data.Entity.Challenge()
            {
                Description = body.Description,
                Name = body.Name,
            });

            return Ok(resutlt);

        }


        [HttpPatch]
        [Route(("challenge/{challengeId}"))]
        public ActionResult<UpdateChallengeResponse> EditChallenge(Guid challengeId, [FromBody] UpdateChallengeRequest body) {
            var challenge = Domain.Challenge.FindChallengeById(challengeId);
            challenge.Description =  body.Description;
            challenge.Name = body.Name;
            var updateChallenge = Domain.Challenge.UpdateChallenge(challenge);
            var result = new UpdateChallengeResponse()
            {
                Description = updateChallenge.Description,
                Name = updateChallenge.Name,
            };
            return Ok(result);
        }


        [HttpDelete]
        [Route("challenge/{challengeId}")]
        public ActionResult<DeleteChallengeResponse> DeleteChallenge(Guid challengeId)
        {
            var challenge = Domain.Challenge.DeleteChallengeById(challengeId);
            var result = new DeleteChallengeResponse()
            {
                Name = challenge.Name,
                Description = challenge.Description,
            };

            return Ok();
        }

        

    }
}
