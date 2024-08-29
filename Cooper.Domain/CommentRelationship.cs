using Microsoft.EntityFrameworkCore.ChangeTracking;
using Cooper.Data;

namespace Cooper.Domain
{
    public class CommentRelationship
    {
        private CommentRelationship(long id, CooperDbContext _db)
        {
            _cachedRecord = _db.CommentRelationship.FirstOrDefault(c => c.Id == id);
        }
        private CommentRelationship(Data.Entity.CommentRelationship commentRelationship){
            _cachedRecord = commentRelationship;
        }
     
        public static CommentRelationship Create(long postId, long parentId, CooperDbContext _db)
        {
            Data.Entity.CommentRelationship commentRelationship = new Data.Entity.CommentRelationship()
            {
                PostId = postId ,
                ParentId = parentId
            };
        
            EntityEntry<Data.Entity.CommentRelationship> entityEntry = _db.CommentRelationship.Add(commentRelationship);
            _db.SaveChanges();
            return new CommentRelationship(entityEntry.Entity.Id,_db);
        }
      
        public static List<CommentRelationship> FindCommentsByParentId(long parentId,long postId, CooperDbContext _db){
        return _db.CommentRelationship.Where(x => x.ParentId == parentId && x.PostId == postId)
            .ToList().Select(x=>new CommentRelationship(x)).ToList();
        }

        private Data.Entity.CommentRelationship? _cachedRecord;
        public long Id { get => _cachedRecord.Id; }
        public long ParentId { get => _cachedRecord.ParentId; }
        public long PostId { get => _cachedRecord.PostId; } 
    }

}
