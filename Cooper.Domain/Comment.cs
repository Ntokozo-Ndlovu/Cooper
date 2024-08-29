using Microsoft.EntityFrameworkCore.ChangeTracking;
using Cooper.Data;

namespace Cooper.Domain
{
    public class Comment : DomainBase
    {
        private Comment(Data.Entity.Comment comment)
        {
            _cachedRecord = comment;
        }

        private Comment(long id, CooperDbContext _db)
        {
            this._cachedRecord = _db.Comment.First(x => x.Id == id);
        }

        private Comment(long id, long parentId, CooperDbContext _db)
        {
            this.ParentId = parentId;
            this._cachedRecord = _db.Comment.First(x => x.Id == id);
        }


        public static Comment Create(string title, string body, long parentId, CooperDbContext _db)
        {

            Data.Entity.Comment comment = new Data.Entity.Comment()
            {
                Title = title,
                Body = body,
            };
            EntityEntry<Data.Entity.Comment> commentTracking = _db.Comment.Add(comment);
            _db.SaveChanges();
            return new Comment(commentTracking.Entity);
        }

        public static List<Comment> FindByPostId(long postId, CooperDbContext _db, long parentId = 0)
        {
            List<Comment> parentComments = CommentRelationship.FindCommentsByParentId(parentId, postId, _db).Select(x => new Comment(x.Id, _db)).ToList();
            return BuildTrees(parentComments, postId, _db);
        }


        public static List<Comment> BuildTrees(List<Comment> parentComments, long postId, CooperDbContext _db)
        {
            parentComments.ForEach(comment =>
            {
                BuildTree(comment, postId, _db);
            });
            return parentComments;
        }

        public static void BuildTree(Comment comment, long postId, CooperDbContext _db)
        {
            List<Comment> children = CommentRelationship.FindCommentsByParentId(comment.Id, postId, _db)
                .Select(x => new Comment(x.Id, _db)).ToList();
            children.ForEach(child =>
             {
                 BuildTree(child, postId, _db);
             });
            comment.Comments = children;
        }

        private Data.Entity.Comment _cachedRecord { get; set; }
        public long Id { get => _cachedRecord.Id; }
        public string Title { get => _cachedRecord.Title; }
        public long ParentId { get; set; }
        public List<Comment> Comments { get; set; }
        public string Body { get => _cachedRecord.Body; }
    }
}
