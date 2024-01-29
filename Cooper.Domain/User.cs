using Cooper.Data;

namespace Cooper.Domain
{
    public class User
    {

        static CooperDbContext _db = new CooperDbContext();

        private User(Data.Entity.User user)
        {
            this.Id = user.Id;
            this.UserName = user.UserName;
            this.AddressId = user.AddressId;
            this.PersonId = user.PersonId;
            this.ContactId = user.ContactId;
            this.EntityId = user.EntityId;  
        }

        private User(Data.Entity.User user, Guid userUUID)
        {
            this.Id = user.Id;
            this.UserName = user.UserName;
            this.AddressId = user.AddressId;
            this.PersonId = user.PersonId;
            this.ContactId = user.ContactId;
            this.EntityId = user.EntityId;
            this.UserUUID = userUUID;
        }


        public static User FindByUserUUID(Guid uuid)
        {
            var entity = Entity.FindEntityById(uuid);
            var user = _db.User.FirstOrDefault(user => user.EntityId == entity.Id);
            return user == null ? throw new Exception("User not Found") : new User(user, entity.UUID);
        }


        public static User Create(Data.Entity.User user)
        {
            var entity = Entity.CreateEntity();
            user.EntityId = entity.Id;
            var newUser = _db.User.Add(user);
            _db.SaveChanges();
            return new User(newUser.Entity,entity.UUID);
        }

        public static User Create(Data.Entity.User user, Person person, Address address, Contact contact)
        {
            var entity = Entity.CreateEntity();
            user.AddressId = address.Id;
            user.ContactId = contact.Id;
            user.EntityId= entity.Id;
            user.PersonId = person.Id;
            var newUserChanges = _db.User.Add(user);
            _db.SaveChanges();
            return new User(newUserChanges.Entity,entity.UUID);
        }

        public static User Create(string userName, Person person, Address address, Contact contact)
        {
            var user = new Data.Entity.User();
            var entity = Entity.CreateEntity();
            user.UserName = userName;
            user.AddressId = address.Id;
            user.ContactId = contact.Id;
            user.EntityId = entity.Id;
            user.PersonId = person.Id;
            var newUserChanges = _db.User.Add(user);
            _db.SaveChanges();
            return new User(newUserChanges.Entity, entity.UUID);
        }

        public Guid UserUUID { get; }
        public int Id { get; }
        
        public string UserName { get; }

        public int PersonId { get; }
        public int AddressId { get; }
        public int ContactId { get; }

        public int EntityId { get; }
    }
}
