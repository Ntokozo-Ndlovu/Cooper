namespace Cooper.Data.Entity
{
    public class Challenge
    {
        public long Id { get; set; }
        public Guid ChallengeGuid {get; set;}
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Price { get; set; }

    }
}
