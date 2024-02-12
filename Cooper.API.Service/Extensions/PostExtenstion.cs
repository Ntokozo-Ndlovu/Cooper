

using System.Net;
using Cooper.API.Response.Post;

namespace Cooper.API.Service.Extensions
{
  public static class PostExtenstion{
        public static LikePostResponse ToApiModel(this Cooper.Domain.Like like)
        {
            return new LikePostResponse()
            {
                UserId = like.UserId,
                Username = like.Username,
            };
        }
        public static FindPostResponse ToApiModel(this Cooper.Domain.Post post)
        {
            return new FindPostResponse()
            {
                Title = post.Title,
                Comments = post.Comments.Select(comment => new Comment(){Body = comment.Body}).ToList(),
                Description = post.Description,
                Like  = post.Likes.Select(like => new Common.Like() { Username = like.Username, UserId = like.UserId}).ToList(),
                Media = post.Media.Select(media => new Media() { Type = media.MediaType, Url = media.Link}).ToList() ,
                ChallengeId = post.ChallengeId,
                PostId = post.PostId
            };
        }
    }
}
