using Cooper.API.Request.Post;
using Cooper.API.Response.Post;
using Cooper.Data;
using Cooper.Data.Entity;
using Cooper.Domain;
using Cooper.API.Service.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Cooper.API.Service.Controllers
{

    public class PostController : BaseController
    {

        public PostController(CooperDbContext context) {
            new DomainBase(context);
        }

        [HttpGet]
        [Route("post/{postId}")]
        public ActionResult<FindPostResponse> GetPostById(Guid postId)
        {
            var post = new Domain.Post(postId);
            var response = new FindPostResponse()
            {
                Description = post.Description,
                Like = post.Likes,
            };
            return Ok(response);
        }

        [HttpGet]
        [Route("post")]
        public ActionResult<List<FindPostResponse>> GetPosts([FromQuery] string challengeId)
        {
            List<FindPostResponse> list = new List<FindPostResponse>();

            if (challengeId != null)
            {
                var postsByChallengeList = Domain.Post.FindPostByChallengeById(Guid.Parse(challengeId));
                postsByChallengeList.ForEach(post =>
                {
                    list.Add(post.ToApiModel());
                });
                return Ok(list);
            }
      
            var postList = Domain.Post.FindAllPost();
            postList.ForEach(post =>
            {
                list.Add(post.ToApiModel());
            });
            return Ok(list);
        }

        [HttpPost]
        [Route("post")]
        public ActionResult<Domain.Post> CreatePost([FromBody] Request.Post.CreatePostRequest post)
        {
            var newPost = new Data.Entity.Post()
            {
                Description = post.Description,
                Likes = post.Likes
            };
            var createdPost = Domain.Post.Create(newPost);
            return Ok(createdPost);
        }

        [HttpDelete]
        [Route("post/{postId}")]
        public ActionResult<FindPostResponse> DeletePost(Guid postId)
        {
            var post = Domain.Post.DeletePost(postId);
            var response = new FindPostResponse()
            {
                Description = post.Description,
                Like = post.Likes
            };

            return Ok(response);
        }

        [HttpPatch]
        [Route("post/{postId}")]
        public ActionResult<UpdatePostResponse> UpdatePost(Guid postId, [FromBody]UpdatePostRequest postData)
        {
            var post = Domain.Post.FindById(postId);
            post.Description = postData.Description;
            post.Likes = postData.Likes;
            var tempPost = Domain.Post.UpdatePost(post);

            var response = new UpdatePostResponse()
            {
                Description = tempPost.Description,
                Likes = tempPost.Likes
            };
            return Ok(response);
        }

    }
}
