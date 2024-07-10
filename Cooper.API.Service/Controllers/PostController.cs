using Cooper.API.Request.Post;
using Cooper.API.Response.Post;
using Cooper.Data;
using Cooper.API.Service.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Cooper.API.Service.Controllers
{

    public class PostController : BaseController
    {
        private readonly CooperDbContext _db;
        public PostController(CooperDbContext context) {
           this._db = context;
        }

        [HttpGet]
        [Route("post/{postId}")]
        public ActionResult<FindPostResponse> GetPostById(long postId)
        {

            var post = Domain.Post.FindById(postId, _db);
            var response = new FindPostResponse()
            {
                Description = post.Description,
           
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
                var postsByChallengeList = Domain.Post.FindByChallengeById(Guid.Parse(challengeId), _db);
                postsByChallengeList.ForEach(post =>
                {
                    list.Add(post.ToApiModel());
                });
                return Ok(list);
            }

            var postList = Domain.Post.FindAll(_db);
         
            postList.ForEach(post =>
            {     
                list.Add(post.ToApiModel());
            });
            return Ok(list);
        }

        [HttpPost]
        [Route("post")]
        public ActionResult<CreatePostResponse> CreatePost([FromBody] Request.Post.CreatePostRequest post)
        {
            var createdPost = Domain.Post.Create(post.Title, post.Description, post.ChallengeId, _db);
            return Ok(createdPost);
        }

        [HttpDelete]
        [Route("post/{postId}")]
        public ActionResult<FindPostResponse> DeletePost(long postId)
        {
            var post = Domain.Post.DeleteById(postId,_db);
            var response = new FindPostResponse()
            {
                Description = post.Description,
            };

            return Ok(response);
        }

        [HttpPatch]
        [Route("post/{postId}")]
        public ActionResult<UpdatePostResponse> UpdatePost(long postId, [FromBody]UpdatePostRequest postData)
        {
            var post = Domain.Post.Update(postId,_db,title:postData.Title,description:postData.Description );
           var response = new UpdatePostResponse()
            {
                Description = post.Description,
            };
            return Ok(response);
        }

        [HttpPost]
        [Route("post/like")]
        public ActionResult<LikePostResponse> LikePost([FromBody] LikePostRequest body)
        {
            Console.WriteLine($"Like: {body.PostId} {body.UserId}", _db);
            var post = Domain.Post.FindById(body.PostId, _db);
            var user = Domain.User.FindById(body.UserId, _db);
            var like = Domain.Like.Create(user.Id, post.Id, _db);        
            return Ok(like.ToApiModel());
        }

        [HttpDelete]
        [Route("post/like")]
        public ActionResult<LikePostResponse> DeleteLikePost([FromBody] LikePostRequest body)
        {
            var post = Domain.Post.FindById(body.PostId, _db);
            var user = Domain.User.FindById(body.UserId, _db);
            var like = Domain.Like.RemoveByPostIdAndUserId(user.Id, post.Id, _db);
            return Ok(like.ToApiModel());
        }
    }
}
