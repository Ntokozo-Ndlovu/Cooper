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

        public static Cooper.Data.Entity.Post AddPost(Cooper.Data.Entity.Post post) {
            var entity = Entity.createEntity() ?? throw new Exception("Entity Not Created");
            post.EntityId = entity.Id;
            var createdPost = _db.Add(post);
            _db.SaveChanges();

            return createdPost.Entity;

        }
    }
}
