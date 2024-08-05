namespace Cooper.Data.Entity
{
    public class User
    {
        public long Id { get; set; }
        public string UserName { get; set; }    
        public long PersonId {  get; set; }
        public long AddressId { get; set; }
        public long ContactId { get; set; }
    }
}
