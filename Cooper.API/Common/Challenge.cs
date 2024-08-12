namespace Cooper.API.Common
{
    public class Challenge
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Price { get; set; }
    }
}
