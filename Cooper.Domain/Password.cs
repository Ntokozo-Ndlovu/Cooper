

using Cooper.Data;

namespace Cooper.Domain
{
    public class Password
    {
        private Password(Data.Entity.Password password)
        {
            this.PasswordKey = password.PasswordKey;
            this.UserId = password.UserId;
        }


        public static Password FindById(long id, CooperDbContext _db)
        {
            var password = _db.Password.FirstOrDefault(password => password.Id == id) ?? throw new Exception("Password Not Found");
            return new Password(password);
        }
        
        public static Password FindByUserId(long userId,CooperDbContext _db){
            var password = _db.Password.FirstOrDefault(password => password.UserId == userId) ?? throw new Exception("Password Not Found");
            return new Password(password);
        }

        public static Password Create(string passwordKey, long userId, CooperDbContext _db)
        {
            var password = new Data.Entity.Password()
            {
                PasswordKey = passwordKey,
                UserId = userId
            };
            var results = _db.Password.Add(password);
            _db.SaveChanges();
            return new Password(password);
        }

        public string PasswordKey { get; }
        private long UserId { get; }
    }
}
