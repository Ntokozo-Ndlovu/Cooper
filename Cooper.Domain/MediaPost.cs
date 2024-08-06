using Cooper.Data;

namespace Cooper.Domain
{
    public class MediaPost
    {

        private MediaPost() { }
        private MediaPost(long postId, long mediaId)
        {
            this.PostId = postId;
            this.MediaId = mediaId;
        }

        public static List<Media> FindAllMediaByPostId(long postId, CooperDbContext _db)
        {
            try
            {
                List<Media> mediaPosts = _db.MediaPost.Where(mediaPost => mediaPost.PostId == postId)
                   .Select(mediaPost => new MediaPost(mediaPost.PostId, mediaPost.MediaId)).ToList()
                   .Select(mp => Media.FindById(mp.MediaId, _db)).ToList();
                return mediaPosts;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public long PostId { get; }
        public long MediaId { get; }
    }
}
