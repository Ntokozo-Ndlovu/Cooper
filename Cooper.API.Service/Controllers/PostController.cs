using System.Net;
using Microsoft.AspNetCore.Mvc;
using Cooper.API.Request.Post;
using Cooper.API.Response.Post;
using Cooper.Data;
using Cooper.API.Service.Extensions;

namespace Cooper.API.Service.Controllers
{

    public class PostController : BaseController
    {
        private readonly CooperDbContext _db;
        public PostController(CooperDbContext context)
        {
            this._db = context;
        }

        [HttpGet]
        [Route("post/{postId}")]
        public FindPostResponse GetPostById(long postId)
        {

            Domain.Post post = Domain.Post.FindById(postId, _db);
            FindPostResponse response = new FindPostResponse(HttpStatusCode.OK, "")
            {
                Post = post.DTO()
            };
            return response;
        }

        [HttpGet]
        [Route("post")]
        public FindPostsResponse GetPosts([FromQuery] string challengeId)
        {
            FindPostsResponse response = new FindPostsResponse(HttpStatusCode.OK,""){
                Posts = new List<Common.Post>()
            };

            if (challengeId != null)
            {
                List<Domain.Post> postsByChallengeList = Domain.Post.FindByChallengeById(Guid.Parse(challengeId), _db);
                postsByChallengeList.ForEach(post =>
                {
                    List<Domain.Media> mediaItemsForPost = Domain.MediaPost.FindAllMediaByPostId(post.Id, _db);
                    response.Posts.Add(post.DTO(mediaItemsForPost));
                });
                return response;
            }

            List<Domain.Post> postList = Domain.Post.FindAll(_db);

            postList.ForEach(post =>
            {
                List<Domain.Media> mediaItemsForPost = Domain.MediaPost.FindAllMediaByPostId(post.Id, _db);
                response.Posts.Add(post.DTO(mediaItemsForPost));
            });
            return response;
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
        public DeletePostResponse DeletePost(long postId)
        {
            Domain.Post post = Domain.Post.DeleteById(postId, _db);
            DeletePostResponse response = new DeletePostResponse(HttpStatusCode.OK,"")
            {
             Post = post.DTO()
            };

            return response;
        }

        [HttpPatch]
        [Route("post/{postId}")]
        public UpdatePostResponse  UpdatePost(long postId, [FromBody] UpdatePostRequest postData)
        {
            Domain.Post post = Domain.Post.Update(postId, _db, title: postData.Title, description: postData.Description);
            UpdatePostResponse response = new UpdatePostResponse(HttpStatusCode.OK, "")
            {
            Post = post.DTO()
            };
            return response;
        }


        [HttpGet]
        [Route("post/like/{postId}")]
        public LikeCountForPostResponse FetchLikesForPost(long postId)
        {
            List<Domain.Like> likes = Domain.Like.FindByPostId(postId, _db);
            LikeCountForPostResponse response = new LikeCountForPostResponse(HttpStatusCode.OK,""){
                Likes = likes.DTO()
            };
            return response;
        }

        [HttpPost]
        [Route("post/like")]
        public LikePostResponse LikePost([FromBody] LikePostRequest body)
        {

            Domain.Post post = Domain.Post.FindById(body.PostId, _db);
            Domain.User user = Domain.User.FindById(body.UserId, _db);
            Domain.Like like = Domain.Like.Create(user.Id, post.Id, _db);
            LikePostResponse response = new LikePostResponse(HttpStatusCode.OK, ""){
                    Like = like.DTO(post.Id,user.UserName) 
            };
            return response;
        }

        [HttpDelete]
        [Route("post/like")]
        public DeleteLikePostResponse DeleteLikePost([FromBody] LikePostRequest body)
        {
            Domain.Post post = Domain.Post.FindById(body.PostId, _db);
            Domain.User user = Domain.User.FindById(body.UserId, _db);
            Domain.Like like = Domain.Like.RemoveByPostIdAndUserId(user.Id, post.Id, _db);
            DeleteLikePostResponse response = new DeleteLikePostResponse(HttpStatusCode.OK, ""){
                Like = like.DTO(post.Id, user.UserName)
            };
            return response;
        }
    }
}
