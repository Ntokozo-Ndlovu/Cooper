namespace Cooper.Data.Entity
{
    public class Password
    {
        public long Id { get; set; }
        public string PasswordKey { get; set; }
        public long UserId { get; set; }

    }
}
