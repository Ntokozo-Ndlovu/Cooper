using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using Cooper.Data;
using Cooper.Data.Entity;

namespace Cooper.Domain
{
    public class Like
    {
    
        private Like(Data.Entity.Like like,Guid userId, string username) {
            this.Id = like.Id;
            this.UserId = userId;
            this.Username = username;
            
    }
        

        public static List<Like> FindByPostId(int postId, CooperDbContext _db)
        {
            var likes = _db.Like.Where(x => x.PostId == postId).ToList();
          
            List<Like> results = new List<Like>();
            foreach(var like in likes)
            {
                var user = User.FindById(like.UserId,_db);  
                var entityId = like.EntityId;
                var username = User.FindById(like.UserId, _db).UserName;

                results.Add(new Like(like, user.UserUUID, username));

                System.Console.WriteLine($"Find Like userId {results.Count}");
            }

            return results;
        }

        public static Like Delete(int userId, int postId, CooperDbContext _db)
        {
            var like = _db.Like.FirstOrDefault((x) => x.UserId == userId && x.PostId == postId)?? throw new Exception("Like Not Found");
            var user = User.FindById(like.UserId, _db);
            var post = Post.FindById(like.PostId, _db);
            var entityId = like.EntityId;
            var username = User.FindById(like.UserId, _db).UserName;

            _db.Like.Remove(like);
            _db.SaveChanges();

            return new Like(like,user.UserUUID,username);
        }
        
        public static Like Delete(Guid userId, Guid postId, CooperDbContext _db)
        {
            var user = User.FindByUserUUID(userId, _db);
            var post = Post.FindById(postId, _db);
            var like = _db.Like.FirstOrDefault((x) => x.UserId == user.Id && x.PostId == post.Id) ?? throw new Exception("Like Not Found");
            var username = User.FindById(like.UserId, _db).UserName;

            _db.Like.Remove(like);
            _db.SaveChanges();

            return new Like(like,user.UserUUID,username);
        }

        public static Like Create(int userId, int postId, CooperDbContext _db)
        {
            var existingLike = _db.Like.FirstOrDefault(x => x.UserId == userId && x.PostId == postId);
            var user = User.FindById(userId, _db);
            var post = Post.FindById(postId, _db);
            var username = User.FindById(userId, _db).UserName;

            if (existingLike == null)
            {
                var entity = Entity.CreateEntity(_db);
                var like = new Data.Entity.Like();
                like.EntityId = entity.Id;
                like.UserId = userId;
                like.PostId = postId;

                var results = _db.Like.Add(like);
                _db.SaveChanges();

                return new Like(results.Entity,user.UserUUID, username);
            }

            return new Like(existingLike , user.UserUUID, username);
        }
        
        public int Id { get; }
        public Guid UserId { get; }
        public string Username { get; }

    }
}
