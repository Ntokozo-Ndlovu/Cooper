using Cooper.Data;

namespace Cooper.Domain
{
    public class Address:DomainBase
    {
        private Address(Data.Entity.Address address) {
        this.Id = address.Id;
        this.StreetName = address.StreetName;
        this.Suburb = address.Suburb;
        this.City = address.City;   
        this.PostalCode = address.PostalCode;
        }

        public static Address FindById(long id, CooperDbContext _db)
        {
            var address = _db.Address.FirstOrDefault(x => x.Id == id) ?? throw new Exception("Address Not Found");
            return new Address(address);
        }

        public static Address Create(string streetName, string suburb, string city, string postalCode, CooperDbContext _db)
        {
            var address = new Data.Entity.Address(){
            StreetName = streetName,
            Suburb = suburb,
            City = city,
            PostalCode = postalCode
            };
            _db.Address.Add(address);
            _db.SaveChanges();
           return new Address(address);
        }

        public long Id { get;  }
        public string StreetName { get; }
        public string Suburb { get; }
        public string City { get; }
        public string PostalCode { get; }
    }
}
