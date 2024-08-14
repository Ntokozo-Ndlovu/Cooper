using Cooper.API.Common;

namespace Cooper.API.Service.Extensions
{
    public static class LikeExtensions
    {
        public static Like DTO (this Domain.Like like, long postId, string username ){
            return new Like(){
                Username = username,
                PostId = postId
            };
        }

        public static Like DTO(this List<Domain.Like> likes)
        {
            return new Like()
            {
                Likes = likes.Count(),

            };

        }
        public static Like DTO(this List<Domain.Like> likes, long postId)
        {
            return new Like()
            {
                Likes = likes.Count(),
                PostId = postId

            };

        }

    }
}
