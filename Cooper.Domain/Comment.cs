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

        public static Comment Delete(Comment comment)
        {
            var commentItem = db.Comment.FirstOrDefault(x => x.Id == comment.Id) ?? throw new Exception("comment not found");
            db.Comment.Remove(commentItem);
            db.SaveChanges();

            return new Comment(commentItem);

        }

        public int Id { get; }
        public string Body { get; }
        public int EntityId { get;  }

        public int Entity { get; }
    }
}
