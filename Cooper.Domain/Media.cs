using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cooper.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Cooper.Domain
{
    public class Media:DomainBase
    {
        private Media(Data.Entity.Media media)
        {
            this.Id = media.Id;
            this.MediaGuid = media.MediaGuid;
            this.MediaType = media.MediaType;   
            this.Link = media.Link;
            this.EntityId   = media.EntityId;
            this.Entity = media.Entity;
        }
        public static Data.Entity.Media GetById(int id, CooperDbContext _context)
        {
            var media = _context.Media.FirstOrDefault(media => media.Id == id) ?? throw new Exception("Media not found"); 
            return media;
        }

        
        public static List<Media> FindAllMediaForEntityById(Guid entityId, CooperDbContext _context)
        {
            var entity = Domain.Entity.FindEntityById(entityId,_context);
            return _context.Media.Where(media => media.Entity == entity.Id).Select(media => new Media(media)).ToList();
        }

        public static Media Delete(Media media, CooperDbContext _context)
        {
            var mediaItem = _context.Media.FirstOrDefault(x => x.Id == media.Id) ?? throw new Exception("Media does not exists");
            _context.Media.Remove(mediaItem);
            _context.SaveChanges();
            return new Media(mediaItem);
        }


        public int Id { get; }
        public Guid MediaGuid { get; }
        public int MediaType { get; }
        public string Link { get; }
        public int EntityId { get; }
        public int Entity { get; }
    }
}
