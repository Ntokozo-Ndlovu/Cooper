namespace Cooper.API.Common
{

    public class Comment
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public long ParentId {get; set; }
        public List<Comment> Comments {get; set;}
        public long PostId { get; set; }
    }

}
