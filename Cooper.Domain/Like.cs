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
        private static CooperDbContext _db = new CooperDbContext();
        
        
        private Like(Data.Entity.Like like,Guid userId, string username) {
            this.Id = like.Id;
            this.UserId = userId;
            this.Username = username;
            
    }
        

        public static List<Like> FindByPostId(int postId)
        {
            var likes = _db.Like.Where(x => x.PostId == postId).ToList();
          
            List<Like> results = new List<Like>();
            foreach(var like in likes)
            {
                var user = User.FindById(like.UserId);  
                var entityId = like.EntityId;
                var username = User.FindById(like.UserId).UserName;

                results.Add(new Like(like, user.UserUUID, username));

                System.Console.WriteLine($"Find Like userId {results.Count}");
            }

            return results;
        }

        public static Like Delete(int userId, int postId)
        {
            var like = _db.Like.FirstOrDefault((x) => x.UserId == userId && x.PostId == postId)?? throw new Exception("Like Not Found");
            var user = User.FindById(like.UserId);
            var post = Post.FindById(like.PostId);
            var entityId = like.EntityId;
            var username = User.FindById(like.UserId).UserName;

            _db.Like.Remove(like);
            _db.SaveChanges();

            return new Like(like,user.UserUUID,username);
        }
        
        public static Like Delete(Guid userId, Guid postId)
        {
            var user = User.FindByUserUUID(userId);
            var post = Post.FindById(postId);
            var like = _db.Like.FirstOrDefault((x) => x.UserId == user.Id && x.PostId == post.Id) ?? throw new Exception("Like Not Found");
            var username = User.FindById(like.UserId).UserName;

            _db.Like.Remove(like);
            _db.SaveChanges();

            return new Like(like,user.UserUUID,username);
        }

        public static Like Create(int userId, int postId)
        {
            var existingLike = _db.Like.FirstOrDefault(x => x.UserId == userId && x.PostId == postId);
            var user = User.FindById(userId);
            var post = Post.FindById(postId);
            var username = User.FindById(userId).UserName;

            if (existingLike == null)
            {
                var entity = Entity.CreateEntity();
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
