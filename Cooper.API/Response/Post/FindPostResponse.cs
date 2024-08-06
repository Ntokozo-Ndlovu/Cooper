using Cooper.Data.Entity;

namespace Cooper.API.Response.Post
{
    public class FindPostResponse
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public long PostId { get; set; }
        public Guid ChallengeId {get; set;}
        public List<Media> Media { get; set;} 
}
}
