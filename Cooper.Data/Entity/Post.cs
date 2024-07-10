namespace Cooper.Data.Entity
{
    public class Post
    {
        public long Id { get; set; }
        public string Description {  get; set; }
        public string Title { get; set; }
        public Guid ChallengeId { get; set; }
    }
}
