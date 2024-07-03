

using Cooper.Data;

namespace Cooper.Domain
{
    public class Password
    {
        private Password(Data.Entity.Password password)
        {
            this.Id = password.Id;
            this.PasswordKey = password.PasswordKey;
            this.EntityId = password.EntityId;
            this.UserId = password.UserId;
        }


        public static Password Find(User user, CooperDbContext _db)
        {
            var password = _db.Password.FirstOrDefault(password =>  password.UserId == user.Id) ?? throw new Exception("Password Not Found");
            return new Password(password);
        }

        public static Password Create(Data.Entity.Password password, User user, CooperDbContext _db)
        {
            var entity = Entity.CreateEntity(_db);
            password.EntityId = entity.Id;
            password.UserId = user.Id;
            var results = _db.Password.Add(password);
            _db.SaveChanges();
            return new Password(results.Entity);
        }


        public int Id { get; }
        public string PasswordKey { get; }
        public int EntityId { get; }
        public int UserId { get; }
    }
}
