using Cooper.API.Request.Challenge;
using Cooper.API.Response.Challenge;
using Cooper.API.Service.Extensions;
using Cooper.Data;
using Microsoft.AspNetCore.Mvc;

namespace Cooper.API.Service.Controllers
{
    public class ChallengeController: BaseController
    {
        private readonly CooperDbContext _db;

        public ChallengeController(CooperDbContext db) {
            _db = db;
        }
        [HttpGet]
        [Route("challenge")]
        public ActionResult<List<FindChallengeResponse>> GetAllChallenge()
        {
            List<Domain.Challenge> challenges =  Domain.Challenge.FindAll(_db);
            List<FindChallengeResponse> result = new List<FindChallengeResponse>();
            challenges.ForEach(challenge => result.Add(challenge.ToApiModel()));
            return Ok(result);
        }


        [HttpGet]
        [Route("challenge/{challengeId}")]
        public ActionResult<FindChallengeResponse> GetChallenge(Guid challengeId)
        {
            var challenge = Domain.Challenge.FindById(challengeId, _db);
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
            var resutlt = Domain.Challenge.Create(body.Name,body.Description,body.StartDate, body.EndDate ,body.Price,_db);

            return Ok(resutlt);

        }


        [HttpPatch]
        [Route(("challenge/{challengeId}"))]
        public ActionResult<UpdateChallengeResponse> EditChallenge(Guid challengeId, [FromBody] UpdateChallengeRequest body) {
            var challenge = Domain.Challenge.UpdateChallenge(challengeId, _db, name: body.Name, description: body.Description,
                    startDate: body.StartDate, endDate: body.EndDate, price:body.Price );
            var result = new UpdateChallengeResponse()
            {
                Description = challenge.Description,
                Name = challenge.Name,
                StartDate = challenge.StartDate,
                EndDate = challenge.EndDate,
                Price = challenge.Price
            };
            return Ok(result);
        }


        [HttpDelete]
        [Route("challenge/{challengeId}")]
        public ActionResult<DeleteChallengeResponse> DeleteChallenge(Guid challengeId)
        {
            var challenge = Domain.Challenge.RemoveChallengeById(challengeId, _db);
            var result = new DeleteChallengeResponse()
            {
                Name = challenge.Name,
                Description = challenge.Description,
                StartDate = challenge.StartDate,
                EndDate = challenge.EndDate,
                Price = challenge.Price
            };

            return Ok();
        }

        

    }
}
