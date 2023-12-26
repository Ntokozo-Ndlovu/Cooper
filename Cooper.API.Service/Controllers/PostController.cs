using Cooper.Data.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Cooper.API.Service.Controllers
{
    [Route("api/v1")]
    public class PostController : ControllerBase
    {
        [HttpGet]
        [Route("post/{postId}")]
        public string GetPostById(Guid postId)
        {
            return "Ok";
        }

        [HttpGet]
        [Route("post")]
        public string GetPosts(string postId)
        {
            return "Post";
        }

        [HttpPost]
        [Route("post")]
        public ActionResult<Post> CreatePost()
        {

            return Ok(new Post()
            {
                Likes = 10,
                Description = "Ntokozo",
                Id = 12
            });
        }

        [HttpDelete]
        [Route("post/{postId}")]
        public ActionResult<Post> DeletePost(Guid postId)
        {
            return Ok();
        }

        [HttpPatch]
        [Route("post/{postId}")]
        public ActionResult UpdatePost(Guid postId)
        {
            return Ok();
        }

    }
}
