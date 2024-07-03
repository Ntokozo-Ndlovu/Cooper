using Cooper.Data.Entity;

namespace Cooper.API.Response.Post
{
    public class FindPostResponse
    {
        public IList<Media> Media { get; set;}
        public string Title { get; set; }
        public string Description { get; set; }
        public IList<Common.Like> Like { get; set; }
        public IList<Comment> Comments {  get; set; }
        public Guid ChallengeId { get; set; }

        public Guid PostId { get; set; }

}
}
