
namespace Cooper.API.Service.Extensions
{
    public static class MediaExtensions
    {
        public static Common.Media DTO(this Domain.Media media)
        {
            return new Common.Media
            {
                Type = media.MediaType,
                Url = media.Link
            };
        }
        public static List<Common.Media> DTO(this List<Domain.Media> media){
            return media.Select(media => media.DTO()).ToList();
        }
    }
}
