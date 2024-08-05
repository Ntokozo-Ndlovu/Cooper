using Cooper.Data;

namespace Cooper.Domain
{
    public class Media : DomainBase
    {
        
        private Media(Data.Entity.Media media)
        {
            this.Id = media.Id;
            this.MediaType = media.MediaType;
            this.Link = media.Link;
        }

        public static Media FindById(long id, CooperDbContext _context)
        {
            var media = _context.Media.FirstOrDefault(media => media.Id == id) ?? throw new Exception("Media not found");
            return new Media(media);
        }

        public static Media RemoveById(long id, CooperDbContext _context)
        {
            var mediaItem = _context.Media.FirstOrDefault(media => media.Id == id) ?? throw new Exception("Media does not exists");
            _context.Media.Remove(mediaItem);
            _context.SaveChanges();
            return new Media(mediaItem);
        }

        public long Id { get; }
        public int MediaType { get; }
        public string Link { get; }
    }
}
