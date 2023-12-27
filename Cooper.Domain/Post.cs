using Cooper.Data;

namespace Cooper.Domain
{
    public class Post
    {
        public static CooperDbContext _db;
        public Post(CooperDbContext context)
        {
            _db = context;
            new Entity(context);
        }

        public static Data.Entity.Post AddPost(Data.Entity.Post post) {
            var entity = Entity.CreateEntity() ?? throw new Exception("Entity Not Created");
            post.EntityId = entity.Id;
            var createdPost = _db.Add(post);
            _db.SaveChanges();

            return createdPost.Entity;

        }
    
        public static Data.Entity.Post FindById(Guid guid)
        {
            var entity = _db.Entities.FirstOrDefault(x => x.UUID == guid) ?? throw new Exception("Entity not found");
            var post = _db.Post.FirstOrDefault(x => x.EntityId == entity.Id) ?? throw new Exception("Post not found");
            return post;
        }

        public static List<Data.Entity.Post> FindAllPost()
        {
            List<Data.Entity.Post> list = _db.Post.ToList(); 
            return list;
        }
        
        public static Data.Entity.Post DeletePost(Guid guid)
        {
            var entity = _db.Entities.FirstOrDefault(x => x.UUID == guid) ?? throw new Exception("Entity not found");
            var post = _db.Post.FirstOrDefault(x => x.EntityId == entity.Id) ?? throw new Exception("Post not found");            

            Entity.DeleteEntity(entity);
            _db.Post.Remove(post);
            _db.SaveChanges();
            return post;
        }

        public static Data.Entity.Post UpdatePost(Data.Entity.Post post)
        {
            var tempPost = _db.Post.FirstOrDefault(p => p.Id == post.Id)?? throw new Exception("Post not found");
            tempPost.Description = post.Description;
            tempPost.Likes = post.Likes;
            _db.Post.Update(tempPost);
            _db.SaveChanges();
            return tempPost;
        }
    }
}
