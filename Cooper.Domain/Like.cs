using Cooper.Data;

namespace Cooper.Domain
{
    public class Like
    {
    
        private Like(Data.Entity.Like like){
            
        }

        public static List<Like> FindByPostId(long postId, CooperDbContext _db)
        {
          var likes = _db.Like.Where(x => x.PostId == postId).Select(like => new Like(like)).ToList();
        
          return likes;
        }
        
        public static Like RemoveByPostIdAndUserId(long postId, long userId, CooperDbContext _db)
        {
            var like = _db.Like.FirstOrDefault((x) => x.UserId == userId && x.PostId == postId)?? throw new Exception("Like Not Found");

            _db.Like.Remove(like);
            _db.SaveChanges();

            return new Like(like);
        }
        
          public static Like Create(long userId, long postId, CooperDbContext _db)
        {
            var like = _db.Like.FirstOrDefault(x => x.UserId == userId && x.PostId == postId);

            if (like == null)
            {
                var newLike = new Data.Entity.Like(){
                UserId = userId,
                PostId = postId
                };
                var results = _db.Like.Add(newLike);
                _db.SaveChanges();

                return new Like(newLike);
            }

            return new Like(like);
        }
        
        public long  UserId { get; }

    }
}
