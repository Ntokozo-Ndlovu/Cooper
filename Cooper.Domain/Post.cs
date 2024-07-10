using Cooper.Data;
using Cooper.Data.Entity;

namespace Cooper.Domain
{
    public class Post : DomainBase
    {
        private Post(Data.Entity.Post post)
        {
            this.Id = post.Id;
            this.Description = post.Description;
            this.Title = post.Title;
            this.ChallengeId = post.ChallengeId;
        }


        public static Post FindById(long id, CooperDbContext _db)
        {
            var post = _db.Post.FirstOrDefault(x => x.Id == id) ?? throw new Exception("Post not found");
            return new Post(post);
        }

        public static List<Post> FindAll(CooperDbContext _db){
            var posts = _db.Post.Select(post => new Post(post)).ToList();
            return posts;
        }

        public static List<Post> FindByChallengeById(Guid challengeId, CooperDbContext _db)
        {
            var posts = _db.Post.Where(post => post.ChallengeId == challengeId).Select(post => new Post(post)).ToList();
            return posts;
        }

        public static Post DeleteById(long postId, CooperDbContext _db)
        {
            var post = _db.Post.FirstOrDefault(post => post.Id == postId) ?? throw new Exception("Post not found");

            _db.Post.Remove(post);
            _db.SaveChanges();
            return new Post(post);
        }

        public static Post Update(long id,CooperDbContext _db, string title= "", string description = "")
        {
            var tempPost = _db.Post.FirstOrDefault(post => post.Id == id) ?? throw new Exception("Post not found");
            if(description != "")
            tempPost.Description = description;
            if(title != "")
            tempPost.Title = title;
            _db.Post.Update(tempPost);
            _db.SaveChanges();
            return new Post(tempPost);
        }

        public static Post Create(string title, string description, Guid challengeId, CooperDbContext _db)
        {
            var post = new Data.Entity.Post(){
                Title = title,
                Description = description,
                ChallengeId = challengeId
            };

            _db.Add(post);
            _db.SaveChanges();
           
            return new Post(post);
        }
        
        public long Id { get; }
        public string Description { get; }
        public string Title { get; }
        public Guid ChallengeId { get; }

    }

}
