using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cooper.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace Cooper.Domain
{
    public class Comment:DomainBase
    {
        private Comment(Data.Entity.Comment comment)
        {
            this.Id = comment.Id;
            this.EntityId = comment.EntityId;
            this.Entity = comment.Entity;
            this.Body = comment.Body;

        }

        public static List<Comment> FindAllCommentForEntity(Guid entityId, CooperDbContext _db)
        {
            var entity = Domain.Entity.FindEntityById(entityId,_db);
            return _db.Comment.Where(comment => comment.Entity == entity.Id).Select(comment => new Comment(comment)).ToList();
        }

        public static Comment Delete(Comment comment, CooperDbContext _db)
        {
            var commentItem = _db.Comment.FirstOrDefault(x => x.Id == comment.Id) ?? throw new Exception("comment not found");
            _db.Comment.Remove(commentItem);
            _db.SaveChanges();

            return new Comment(commentItem);

        }

        public int Id { get; }
        public string Body { get; }
        public int EntityId { get;  }

        public int Entity { get; }
    }
}
