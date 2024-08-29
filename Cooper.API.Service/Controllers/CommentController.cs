using System.Net;
using Microsoft.AspNetCore.Mvc;

using Cooper.API.Response;
using Cooper.API.Request;
using Cooper.API.Service.Extensions;
using Cooper.Data;

namespace Cooper.API.Service
{

    public class CommentController : BaseController
    {
        private readonly CooperDbContext _db;
        public CommentController(CooperDbContext db)
        {
            _db = db;
        }


        [HttpGet("comment/{postId}")]
        public FetchCommentListResponse FetchComments(long postId)
        {
            List<Domain.Comment> comments = Domain.Comment.FindByPostId(postId, _db);
            return new FetchCommentListResponse(HttpStatusCode.OK, "")
            {
                Comments = comments.DTO()
            };
        }


        [HttpPost("comment")]
        public CreateCommentResponse CreateComment([FromBody] CreateCommentRequest request)
        {
            Domain.Comment comment = Domain.Comment.Create(request.Title, request.Body, request.ParentId, _db);

            return new CreateCommentResponse(HttpStatusCode.OK, "")
            {
                Comment = comment.DTO(request.PostId)
            };

        }


    }

}
