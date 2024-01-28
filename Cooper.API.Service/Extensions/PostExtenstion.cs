

using Cooper.API.Response.Post;

namespace Cooper.API.Service.Extensions
{
  public static class PostExtenstion{
        public static FindPostResponse ToApiModel(this Cooper.Domain.Post post)
        {
            return new FindPostResponse()
            {
                Title = post.Title,
                Comments = post.Comments.Select(comment => new Comment(){Body = comment.Body}).ToList(),
                Description = post.Description,
                Like  = post.Likes,
                Media = post.Media.Select(media => new Media() { Type = media.MediaType, Url = media.Link}).ToList() 
            };
        }
    }
}
