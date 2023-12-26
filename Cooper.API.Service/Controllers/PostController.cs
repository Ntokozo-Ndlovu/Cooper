using Cooper.Data;
using Cooper.Data.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Cooper.API.Service.Controllers
{
    [Route("api/v1")]
    public class PostController : ControllerBase
    {

        public PostController(CooperDbContext context) {
            new Cooper.Domain.Post(context);
        }
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
        public ActionResult<Post> CreatePost([FromBody] Post post)
        {

            var createdPost = Cooper.Domain.Post.AddPost(post);
            return Ok(createdPost);
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
