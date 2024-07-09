using Cooper.Data;

namespace Cooper.Domain
{
    public class Contact
    {
        private Contact(Data.Entity.Contact contact)
        {
            this.Id = contact.Id;
            this.Email = contact.Email;
            this.PhoneNumber = contact.PhoneNumber;
        }

        public static Contact Create(string email, string phoneNumber, CooperDbContext _db)
        {
            var contact = new Data.Entity.Contact()
            {
                Email = email,
                PhoneNumber = phoneNumber
            };

            _db.Contact.Add(contact);
            _db.SaveChanges();

            return new Contact(contact);
        }

        public static Contact FindById(int id, CooperDbContext _db)
        {
            var contact = _db.Contact.FirstOrDefault(contact => contact.Id == id) ?? throw new Exception("Contact Not Found");
            return new Contact(contact);
        }

        public long Id { get; }
        public string Email { get; }
        public string PhoneNumber { get; }
    }
}
