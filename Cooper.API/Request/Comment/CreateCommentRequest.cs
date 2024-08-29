
namespace Cooper.API.Request
{
    public class CreateCommentRequest
    {

        public long ParentId { get; set; }
        public long PostId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

    }

}
