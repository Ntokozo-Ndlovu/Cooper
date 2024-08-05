namespace Cooper.Domain

{
    public class Comment:DomainBase
    {
        private Comment(Data.Entity.Comment comment)
        {
            this.Id = comment.Id;
            this.Body = comment.Body;

        }

        public long Id { get; }
        public string Body { get; }
    }
}
