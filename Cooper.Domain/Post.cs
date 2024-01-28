using Cooper.Data;

namespace Cooper.Domain
{
    public class Post: DomainBase
    {
       
        public Post(Guid postEntityUUID)
        {
            var post = FindById(postEntityUUID);
            this.Id = post.Id;
            this.Description = post.Description;
            this.EntityId = post.EntityId;
            this.Likes = post.Likes;   
            this.Title = post.Title;
            this.ChallengeId = post.ChallengeId;
            this.Media = Domain.Media.FindAllMediaForEntityById(postEntityUUID);
            this.Comments = Domain.Comment.FindAllCommentForEntity(postEntityUUID);    
        }

        private Post(Data.Entity.Post post)
        {
            this.Id = post.Id;
            this.Description = post.Description;
            this.EntityId = post.EntityId;
            this.Likes = post.Likes;
            this.Title= post.Title;
            this.ChallengeId = post.ChallengeId;

            var postEntity = new Entity(post.EntityId);
            this.Media = Domain.Media.FindAllMediaForEntityById(postEntity.UUID);
            this.Comments = Domain.Comment.FindAllCommentForEntity(postEntity.UUID);

        }

    
        public static Data.Entity.Post FindById(Guid guid)
        {
            var entity = _db.Entities.FirstOrDefault(x => x.UUID == guid) ?? throw new Exception("Entity not found");
            var post = _db.Post.FirstOrDefault(x => x.EntityId == entity.Id) ?? throw new Exception("Post not found");
            return post;
        }

        public static List<Post> FindAllPost()
        {
            List<Post> list = _db.Post.Select(post => new Post(post)).ToList(); 
            return list;
        }
        
        public static List<Post> FindPostByChallengeById(Guid challengeId)
        {
            List<Post> list = _db.Post.Where((post)=>post.ChallengeId== challengeId).Select(post => new Post(post)).ToList();
            return list;
        }

        public static Post DeletePost(Guid guid)
        {
            var entity = _db.Entities.FirstOrDefault(x => x.UUID == guid) ?? throw new Exception("Entity not found");
            var post = _db.Post.FirstOrDefault(x => x.EntityId == entity.Id) ?? throw new Exception("Post not found");            

            Entity.DeleteEntity(entity);
            _db.Post.Remove(post);
            _db.SaveChanges();
            return new Post(post);
        }

        public static Data.Entity.Post UpdatePost(Data.Entity.Post post)
        {
            var tempPost = _db.Post.FirstOrDefault(p => p.Id == post.Id)?? throw new Exception("Post not found");
            tempPost.Description = post.Description;
            tempPost.Likes = post.Likes;
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

            return new Post(createdPost.Entity);
        }
        public int Id { get;  }
        public string Description { get;  }
        public int Likes { get;  }
        public int EntityId { get;  }
        public string Title { get; }
        public Guid ChallengeId { get; }    

        public IList<Media> Media;
        public IList<Comment> Comments;
    }
}
