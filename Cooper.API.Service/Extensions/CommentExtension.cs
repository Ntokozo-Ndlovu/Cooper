using Cooper.API.Common;

namespace Cooper.API.Service.Extensions
{

    public static class CommentExtension
    {

        public static Comment DTO(this Domain.Comment comment)
        {

            return new Comment()
            {
                ParentId = comment.ParentId,
                Id = comment.Id,
                Title = comment.Title,
                Body = comment.Body,
                Comments = comment.Comments.DTO()
            };
        }

        public static Comment DTO(this Domain.Comment comment, long postId)
        {

            return new Comment()
            {
                ParentId = comment.ParentId,
                Id = comment.Id,
                Title = comment.Title,
                Body = comment.Body,
                PostId = postId,
                Comments = comment.Comments.DTO()
            };
        }

        public static List<Comment> DTO (this List<Domain.Comment> comments){
        
            return comments.Select(x => x.DTO()).ToList();

        }

    }


}
