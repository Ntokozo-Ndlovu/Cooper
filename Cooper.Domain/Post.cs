using Cooper.Data;
using Cooper.Data.Entity;

namespace Cooper.Domain
{
    public class Post : DomainBase
    {
        public static CooperDbContext _db = new CooperDbContext();
      
        private Post(Data.Entity.Post post,Guid postId, List<Like> likes, List<Media> media, List<Comment> comments)
        {
            this.Id = post.Id;
            this.Description = post.Description;
            this.EntityId = post.EntityId;
            this.Title = post.Title;
            this.ChallengeId = post.ChallengeId;
            this.PostId = postId;
            this.Likes = likes;
            this.Media = media;
            this.Comments = comments;
        }


        public static Post FindById(Guid guid)
        {
            var entity = _db.Entities.FirstOrDefault(x => x.UUID == guid) ?? throw new Exception("Entity not found");
            var post = _db.Post.FirstOrDefault(x => x.EntityId == entity.Id) ?? throw new Exception("Post not found");
            var postEntity = Entity.FindEntityById(post.EntityId);
            var postId = Entity.FindEntityById(post.EntityId).UUID;
            var likes = Like.FindByPostId(post.Id);
            var media = Domain.Media.FindAllMediaForEntityById(postEntity.UUID);
            var comments = Domain.Comment.FindAllCommentForEntity(postEntity.UUID);
            return new Post(post,postId,likes,media,comments);
        }

        public static Post FindById(int id)
        {
            var post = _db.Post.FirstOrDefault(x => x.Id == id) ?? throw new Exception("Post not found");

            var postEntity = Entity.FindEntityById(post.EntityId);
            var postId = Entity.FindEntityById(post.EntityId).UUID;
            var likes = Like.FindByPostId(post.Id);
            var media = Domain.Media.FindAllMediaForEntityById(postEntity.UUID);
            var comments = Domain.Comment.FindAllCommentForEntity(postEntity.UUID);
            return new Post(post,postId,likes,media,comments);
        }


        public static List<Post> FindAllPost()
        {
            List<Data.Entity.Post> list = _db.Post.ToList();
            List<Post> posts = new List<Post>();
            foreach(var post in list)
            {
                var postEntity = Entity.FindEntityById(post.EntityId);
                var postId = Entity.FindEntityById(post.EntityId).UUID;
                var likes = Like.FindByPostId(post.Id);
                var media = Domain.Media.FindAllMediaForEntityById(postEntity.UUID);
                var comments = Domain.Comment.FindAllCommentForEntity(postEntity.UUID);
                posts.Add(new Post(post, postId,likes,media,comments)); 
            }
           
            return posts;
        }

        public static List<Post> FindPostByChallengeById(Guid challengeId)
        {
            List<Data.Entity.Post> list = _db.Post.Where(post => post.ChallengeId == challengeId).ToList();
            List<Post> posts = new List<Post>();
            foreach(var post in list)
            {
                var postEntity = Entity.FindEntityById(post.EntityId);
                var postId = Entity.FindEntityById(post.EntityId).UUID;
                var likes = Like.FindByPostId(post.Id);
                var media = Domain.Media.FindAllMediaForEntityById(postEntity.UUID);
                var comments = Domain.Comment.FindAllCommentForEntity(postEntity.UUID);
                posts.Add(new Post(post, postId, likes, media, comments));
            }
            return posts;
        }

        public static Post DeletePost(Guid userId, Guid postId)
        {
            var entity = _db.Entities.FirstOrDefault(x => x.UUID == postId) ?? throw new Exception("Entity not found");
            var post = _db.Post.FirstOrDefault(x => x.EntityId == entity.Id) ?? throw new Exception("Post not found");

            Entity.DeleteEntity(entity);
            var likes = Like.FindByPostId(post.Id);
            foreach(var like in likes)
            {
                Like.Delete(userId, postId);
            }
            var media = Domain.Media.FindAllMediaForEntityById(postId);
            foreach(var mediaItem in media)
            {
                Domain.Media.Delete(mediaItem);     
            }
            var comments = Domain.Comment.FindAllCommentForEntity(postId);
            foreach(var comment in comments)
            {
                Domain.Comment.Delete(comment);
            }


            _db.Post.Remove(post);
            _db.SaveChanges();
            return new Post(post,postId,likes,media,comments);
        }

        public static Data.Entity.Post UpdatePost(Data.Entity.Post post)
        {
            var tempPost = _db.Post.FirstOrDefault(p => p.Id == post.Id) ?? throw new Exception("Post not found");
            tempPost.Description = post.Description;
            tempPost.ChallengeId = post.ChallengeId;
            _db.Post.Update(tempPost);
            _db.SaveChanges();
            return tempPost;
        }

        public static Post Create(Data.Entity.Post post)
        {
            var entity = Entity.CreateEntity() ?? throw new Exception("Entity Not Created");
            post.EntityId = entity.Id;
            var createdPost = _db.Add(post);
            _db.SaveChanges();
            
            
            List<Like> likes = new List<Like>();
            List<Comment> comments = new List<Comment>();
            List<Media> media = new List<Media>();

            return new Post(createdPost.Entity,entity.UUID,likes,media,comments);
        }
        public int Id { get; }
        public string Description { get; }
        public List<Like> Likes { get; }
        public int EntityId { get; }
        public string Title { get; }
        public Guid ChallengeId { get; }
        public Guid PostId { get; }

        public IList<Media> Media;
        public IList<Comment> Comments;
    }

}
