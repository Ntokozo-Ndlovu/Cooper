using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cooper.Data;

namespace Cooper.Domain
{
    public class Contact
    {

        static CooperDbContext _db = new CooperDbContext();

        private Contact(Data.Entity.Contact contact)
        {
            this.Id = contact.Id;
            this.Email = contact.Email;
            this.PhoneNumber = contact.PhoneNumber;
            this.EntityId = contact.EntityId;
        }


        public static Contact Create(Data.Entity.Contact contact)
        {
            var entity = Entity.CreateEntity();
            contact.EntityId = entity.Id; 
            var newContact =  _db.Contact.Add(contact);
            _db.SaveChanges();

            return new Contact(newContact.Entity);
        }
        
        public static Contact FindEntityById(int entityId)
        {
            var contact = _db.Contact.FirstOrDefault(contact => contact.EntityId == entityId) ?? throw new Exception("Contact Not Found") ;
            return new Contact(contact);
        }

        public static Contact FindById(int id)
        {
            var contact = _db.Contact.FirstOrDefault(contact => contact.Id == id) ?? throw new Exception("Contact Not Found");
            return new Contact(contact);
        }

        public int Id { get;  }
        public string Email { get;  }
        public string PhoneNumber { get; }
        public int EntityId { get; }
    }
}
