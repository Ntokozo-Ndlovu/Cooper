using Cooper.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cooper.Data.EntityConfiguration
{
    public class MediaConfiguration: IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> mediaBuilder)
        {
            mediaBuilder.HasKey(x => x.Id);


            createSeedData(mediaBuilder);
        }

        public void createSeedData(EntityTypeBuilder<Media> mediaBuilder)
        {

            mediaBuilder.HasData(new Media() { Id = 1,  MediaType = 0, Link = "https://imageio.forbes.com/specials-images/imageserve/5d35eacaf1176b0008974b54/2020-Chevrolet-Corvette-Stingray/0x0.jpg?format=jpg&crop=4560,2565,x790,y784,safe&width=960" },
            new Media() { Id = 2, MediaType = 0, Link = "https://carwow-uk-wp-3.imgix.net/18015-MC20BluInfinito-scaled-e1666008987698.jpg" },
            new Media() { Id = 3, MediaType = 0, Link = "https://cdn.motor1.com/images/mgl/JO94P6/s1/most-expensive-cars-in-the-world.jpg" },
            new Media() { Id = 4, MediaType = 0, Link = "https://carwow-uk-wp-3.imgix.net/18015-MC20BluInfinito-scaled-e1666008987698.jpg" },
            new Media() { Id = 5, MediaType = 0, Link = "https://i.abcnewsfe.com/a/aae2e440-73a2-4252-a4c9-c7d27f0efda7/mcdonalds-gty-thg-230728_1690559943139_hpMain.jpg" },
            new Media() { Id = 6, MediaType = 0, Link = "https://www.allrecipes.com/thmb/3YpMeC2Za5PkXZFnlNFaBOCtC3c=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/mcdonalds-store-front-4x3-0a58d7e370ce48f7b050203fd478c407.png" },
            new Media() { Id = 7, MediaType = 0, Link = "https://www.foodandwine.com/thmb/K_t1B_xBKIKYm_ZoNIEqaBvuXcQ=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/Burger-King-Everything-Seasoned-Bun-FT-BLOG0922-c8c7859b9c794c42af7700b5b957a874.jpg" },
            new Media() { Id = 8, MediaType = 0, Link = "https://www.thestreet.com/.image/ar_16:9%2Cc_fill%2Ccs_srgb%2Cfl_progressive%2Cq_auto:good%2Cw_1200/MTg3NTA5NzAzMTQ2NzQzMzU2/burger-king-yeti-super-one-pound-beef-burger.jpg" },
            new Media() { Id = 9, MediaType = 0, Link = "https://media-cdn.tripadvisor.com/media/photo-s/11/70/80/ac/chciken.jpg" },
            new Media() { Id = 10, MediaType = 0, Link = "https://www.kimberley.co.za/wp-content/uploads/2022/01/38784_STEERS-AsPhande_Sharing_Meal_Promotion-20220113-KCP-SP-v1_00a.jpg" }
            );

        }

    }
}
