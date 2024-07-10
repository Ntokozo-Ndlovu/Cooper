using Cooper.Data;

namespace Cooper.Domain
{
    public class User
    {
        private User(Data.Entity.User user)
        {
            this.Id = user.Id;
            this.UserName = user.UserName;
            this.AddressId = user.AddressId;
            this.PersonId = user.PersonId;
            this.ContactId = user.ContactId;

        }

        public static User FindUserName(string username, CooperDbContext _db)
        {
            var user = _db.User.FirstOrDefault(user => user.UserName == username) ?? throw new Exception("User not found");
            return new User(user);
        }
        public static User FindById(long id, CooperDbContext _db)
        {
            var user = _db.User.FirstOrDefault(user => user.Id == id) ?? throw new Exception("User not found");
            return new User(user);
        }

        public static User Create(string userName, long personId, long addressId, long contactId, CooperDbContext _db)
        {
            var user = new Data.Entity.User();
            user.UserName = userName;
            user.AddressId = addressId;
            user.ContactId = contactId;
            user.PersonId = personId;
            var newUserChanges = _db.User.Add(user);
            _db.SaveChanges();
            return new User(user);
        }

        public long Id { get; }
        public string UserName { get; }
        public long PersonId { get; }
        public long AddressId { get; }
        public long ContactId { get; }

    }
}
