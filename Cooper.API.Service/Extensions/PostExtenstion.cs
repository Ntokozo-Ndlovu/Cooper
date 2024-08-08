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

        public static LikeCountForPostResponse ToApiModel(this List<Cooper.Domain.Like> likes , long PostId) {
            return new LikeCountForPostResponse(){
                Likes = likes.Count(),
                PostId = PostId 
            };
        }


        public static FindPostResponse ToApiModel(this Cooper.Domain.Post post, List<Media> media)
        {
            return new FindPostResponse()
            {
                Title = post.Title,
                Description = post.Description,
                PostId = post.Id,
                ChallengeId = post.ChallengeId,
                Media = media
            };
        }
    }
}
