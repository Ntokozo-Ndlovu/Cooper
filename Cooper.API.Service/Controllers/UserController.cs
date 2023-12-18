using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace Cooper.API.Service.Controllers
{
    [Route("/api/v1")]
    public class UserController: ControllerBase
    {
        [HttpGet]
        [Route("user/{userId}")]
        public ActionResult GetUser(Guid userId)
        {
            return Ok();
        }

        [HttpPatch]
        [Route("user/{userId}")]
        public ActionResult UpdateUser(Guid userId)
        {
            return Ok();
        }
    }
}
