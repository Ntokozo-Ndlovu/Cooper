using Cooper.API.Response.Post;

namespace Cooper.API.Service.Extensions
{
  public static class PostExtenstion{
        public static LikePostResponse ToApiModel(this Cooper.Domain.Like like)
        {
            return new LikePostResponse()
            {
                UserId = like.UserId,
            };
        }
        public static FindPostResponse ToApiModel(this Cooper.Domain.Post post)
        {
            return new FindPostResponse()
            {
                Title = post.Title,
                Description = post.Description,
                PostId = post.Id,
                ChallengeId = post.ChallengeId
            };
        }
    }
}
