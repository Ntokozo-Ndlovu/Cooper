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
        public ActionResult<FindPostResponse> GetPostById(Guid postId)
        {


            var post = Domain.Post.Create(new Data.Entity.Post() { Description="Hello World"}, _db);
            var response = new FindPostResponse()
            {
                Description = post.Description,
                Like = post.Likes.Select(like => new Common.Like() {UserId = like.UserId, Username = like.Username }).ToList(),
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
                var postsByChallengeList = Domain.Post.FindPostByChallengeById(Guid.Parse(challengeId), _db);
                postsByChallengeList.ForEach(post =>
                {
                    list.Add(post.ToApiModel());
                });
                return Ok(list);
            }

            var postList = Domain.Post.FindAllPost(_db);
         
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
            var newPost = new Data.Entity.Post()
            {
                Description = post.Description,
            };
            var createdPost = Domain.Post.Create(newPost, _db);
            return Ok(createdPost);
        }

        [HttpDelete]
        [Route("post/{postId}")]
        public ActionResult<FindPostResponse> DeletePost(Guid postId,Guid userId)
        {
            var post = Domain.Post.DeletePost(userId,postId,_db);
            var response = new FindPostResponse()
            {
                Description = post.Description,
                Like = post.Likes.Select(like => new Common.Like() { Username = like.Username, UserId = like.UserId}).ToList(),
            };

            return Ok(response);
        }

        [HttpPatch]
        [Route("post/{postId}")]
        public ActionResult<UpdatePostResponse> UpdatePost(Guid postId, [FromBody]UpdatePostRequest postData)
        {
            var domainPost = Domain.Post.FindById(postId, _db);
            var post = new Data.Entity.Post()
            {
                Description = domainPost.Description,
                Title = domainPost.Title,
                ChallengeId = domainPost.ChallengeId,
                
            };
            
            post.Description = postData.Description;
            var tempPost = Domain.Post.UpdatePost(post, _db);

            var response = new UpdatePostResponse()
            {
                Description = tempPost.Description,
            };
            return Ok(response);
        }

        [HttpPost]
        [Route("post/like")]
        public ActionResult<LikePostResponse> LikePost([FromBody] LikePostRequest body)
        {
            Console.WriteLine($"Like: {body.PostId} {body.UserId}", _db);
            var post = Domain.Post.FindById(body.PostId, _db);
            var user = Domain.User.FindByUserUUID(body.UserId, _db);
            var like = Domain.Like.Create(user.Id, post.Id, _db);        
            return Ok(like.ToApiModel());
        }

        [HttpDelete]
        [Route("post/like")]
        public ActionResult<LikePostResponse> DeleteLikePost([FromBody] LikePostRequest body)
        {
            var post = Domain.Post.FindById(body.PostId, _db);
            var user = Domain.User.FindByUserUUID(body.UserId, _db);
            var like = Domain.Like.Delete(user.Id, post.Id, _db);
            return Ok(like.ToApiModel());
        }
    }
}
