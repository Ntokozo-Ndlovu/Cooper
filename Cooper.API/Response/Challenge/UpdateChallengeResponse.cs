namespace Cooper.API.Response.Challenge
{
    public class UpdateChallengeResponse
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Price { get; set; }
    }
}
