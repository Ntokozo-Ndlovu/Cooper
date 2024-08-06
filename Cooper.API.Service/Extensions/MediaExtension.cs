using Cooper.API.Response.Post;

namespace Cooper.API.Service.Extensions
{
    public static class MediaExtensions
    {
        public static Media ToApi(this Domain.Media media)
        {
            return new Media
            {
                Type = media.MediaType,
                Url = media.Link
            };
        }
        public static List<Media> ToApi(this List<Domain.Media> media){
            return media.Select(media => media.ToApi()).ToList();
        }
    }
}
