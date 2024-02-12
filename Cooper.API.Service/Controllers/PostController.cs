using Cooper.API.Request.Post;
using Cooper.API.Response.Post;
using Cooper.Data;
using Cooper.Data.Entity;
using Cooper.Domain;
using Cooper.API.Service.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Runtime.Intrinsics.Arm;

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


            var post = Domain.Post.Create(new Data.Entity.Post() { Description="Hello World"});
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
        public ActionResult<CreatePostResponse> CreatePost([FromBody] Request.Post.CreatePostRequest post)
        {
            var newPost = new Data.Entity.Post()
            {
                Description = post.Description,
            };
            var createdPost = Domain.Post.Create(newPost);
            return Ok(createdPost);
        }

        [HttpDelete]
        [Route("post/{postId}")]
        public ActionResult<FindPostResponse> DeletePost(Guid postId,Guid userId)
        {
            var post = Domain.Post.DeletePost(userId,postId);
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
            var domainPost = Domain.Post.FindById(postId);
            var post = new Data.Entity.Post()
            {
                Description = domainPost.Description,
                Title = domainPost.Title,
                ChallengeId = domainPost.ChallengeId,
                
            };
            
            post.Description = postData.Description;
            var tempPost = Domain.Post.UpdatePost(post);

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
            var post = Domain.Post.FindById(body.PostId);
            var user = Domain.User.FindByUserUUID(body.UserId);
            var like = Domain.Like.Create(user.Id, post.Id);        
            return Ok(like.ToApiModel());
        }

        [HttpDelete]
        [Route("post/like")]
        public ActionResult<LikePostResponse> DeleteLikePost([FromBody] LikePostRequest body)
        {
            var post = Domain.Post.FindById(body.PostId);
            var user = Domain.User.FindByUserUUID(body.UserId);
            var like = Domain.Like.Delete(user.Id, post.Id);
            return Ok(like.ToApiModel());
        }
    }
}
