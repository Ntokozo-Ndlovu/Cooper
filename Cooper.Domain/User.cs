using System.Runtime.Intrinsics.Arm;
using Cooper.Data;
using Microsoft.EntityFrameworkCore;

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

        public static User FindUserName(string username, CooperDbContext _db)
        {
            
            var user = _db.User.FirstOrDefault(user => user.UserName == username) ?? throw new Exception("User does not exists");
            var entity = Entity.FindEntityById(user.EntityId, _db);
            return new User(user, entity.UUID);
        }

        public static User FindByUserUUID(Guid uuid, CooperDbContext _db)
        {
            var entity = Entity.FindEntityById(uuid, _db);
            var user = _db.User.FirstOrDefault(user => user.EntityId == entity.Id) ?? throw new Exception("User not found");
            return new User(user, entity.UUID);
        }

        public static User FindById(int id, CooperDbContext _db)
        {
            var user = _db.User.FirstOrDefault(user => user.Id == id) ?? throw new Exception("User not found");
            var entity = Domain.Entity.FindEntityById(user.EntityId, _db);
            Console.WriteLine($"User and Entity {user.Id} {entity.UUID}", _db);
            return new User(user,entity.UUID);
        }

        public static User Create(Data.Entity.User user, CooperDbContext _db)
        {
            var entity = Entity.CreateEntity(_db);
            user.EntityId = entity.Id;
            var newUser = _db.User.Add(user);
            _db.SaveChanges();
            return new User(newUser.Entity,entity.UUID);
        }

        public static User Create(Data.Entity.User user, Person person, Address address, Contact contact,CooperDbContext _db)
        {
            var entity = Entity.CreateEntity(_db);
            user.AddressId = address.Id;
            user.ContactId = contact.Id;
            user.EntityId= entity.Id;
            user.PersonId = person.Id;
            var newUserChanges = _db.User.Add(user);
            _db.SaveChanges();
            return new User(newUserChanges.Entity,entity.UUID);
        }

        public static User Create(string userName, Person person, Address address, Contact contact, CooperDbContext _db)
        {
            var user = new Data.Entity.User();
            var entity = Entity.CreateEntity(_db);
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
