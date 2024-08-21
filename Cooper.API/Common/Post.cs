namespace Cooper.API.Common {
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public long PostId { get; set; }
        public Guid ChallengeId {get; set;}
        public bool UserLiked {get; set;}
        public List<Media> Media { get; set;} 
}
}
