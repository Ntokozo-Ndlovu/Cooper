namespace Cooper.API.Request.Post
{
    public class CreatePostRequest
    {
            public string Title { get; set; }
            public string Description { get; set; }
            public int Likes { get; set; }
            public Guid ChallengeId { get; set;} 
    }
}
