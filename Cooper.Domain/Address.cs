using Cooper.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.Domain
{
    public class Address:DomainBase
    {
        static CooperDbContext _db = new CooperDbContext();

        private Address(Data.Entity.Address address) {
        this.Id = address.Id;
        this.EntityId = address.EntityId;
        this.StreetName = address.StreetName;
        this.Suburb = address.Suburb;
        this.City = address.City;   
        this.PostalCode = address.PostalCode;
        }


        public static Address FindByEntityId(int entityId) {
        var address = _db.Address.FirstOrDefault(a => a.EntityId == entityId) ?? throw new Exception("Address Not Found");
        return new Address(address);
        }


        public static Address Create(Data.Entity.Address address)
        {
            var entity = Entity.CreateEntity();
            address.EntityId = entity.Id;
            var newAddress = _db.Address.Add(address);
            _db.SaveChanges();
           return new Address(newAddress.Entity);
        }

        public int Id { get;  }
        public string StreetName { get; }
        public string Suburb { get; }
        public string City { get; }
        public string PostalCode { get; }
        public int EntityId { get; }
    }
}
