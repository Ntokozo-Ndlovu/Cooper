using Microsoft.AspNetCore.Mvc;

namespace Cooper.API.Service.Controllers
{
    [Route("/api/v1")]
    public class ChallengeController: ControllerBase
    {

        [HttpGet]
        [Route("challenge")]
        public ActionResult GetAllChallenge()
        {
            return Ok();
        }

        [HttpGet]
        [Route("challenge/{challengeId}")]
        public ActionResult GetChallenge(Guid challengeId)
        {
            return Ok();
        }

        [HttpPost]
        [Route("challenge")]
        public ActionResult CreateChallenge()
        {
            return Ok();

        }

        [HttpPatch]
        [Route(("challenge/{challengeId}"))]
        public ActionResult EditChallenge(Guid challengeId) {
            return Ok();

        
        }

        [HttpDelete]
        [Route("challenge/{challengeId}")]
        public ActionResult DeleteChallenge(Guid challengeId)
        {
            return Ok();
        }

        

    }
}
