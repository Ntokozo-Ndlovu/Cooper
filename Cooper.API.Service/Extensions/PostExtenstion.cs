using Cooper.API.Response.Post;

namespace Cooper.API.Service.Extensions
{
  public static class PostExtenstion{
    public static Common.Post DTO (this Domain.Post post){
        return new Common.Post(){
        Title = post.Title,
        Description = post.Description,
        PostId = post.Id,
        ChallengeId = post.ChallengeId,
        };
    }

    public static Common.Post DTO (this Domain.Post post, List<Domain.Media> media){
        return new Common.Post(){
        Title = post.Title,
        Description = post.Description,
        PostId = post.Id,
        ChallengeId = post.ChallengeId,
        Media = media.DTO()
        };
    }


   }
}
