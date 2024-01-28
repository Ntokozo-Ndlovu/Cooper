using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cooper.Data;

namespace Cooper.Domain
{
    public class Comment:DomainBase
    {
        private static CooperDbContext db = new CooperDbContext();
        private Comment(Data.Entity.Comment comment)
        {
            this.Id = comment.Id;
            this.EntityId = comment.EntityId;
            this.Entity = comment.Entity;
            this.Body = comment.Body;

        }

        public static List<Comment> FindAllCommentForEntity(Guid entityId)
        {
            var entity = Domain.Entity.FindEntityById(entityId);
            return db.Comment.Where(comment => comment.Entity == entity.Id).Select(comment => new Comment(comment)).ToList();
        }

        public int Id { get; }
        public string Body { get; }
        public int EntityId { get;  }

        public int Entity { get; }
    }
}
