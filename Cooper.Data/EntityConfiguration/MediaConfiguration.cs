using Cooper.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.Data.EntityConfiguration
{
    public class MediaConfiguration: IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> mediaBuilder)
        {
            mediaBuilder.HasKey(x => x.Id);
            mediaBuilder.Property(x => x.EntityId).IsRequired();

            mediaBuilder.Property(x => x.EntityId).IsRequired();
            mediaBuilder.HasAlternateKey(x => x.EntityId);

            createSeedData(mediaBuilder);
        }

        public void createSeedData(EntityTypeBuilder<Media> mediaBuilder)
        {

            mediaBuilder.HasData(new Media() { Id = 1, EntityId = 2, Entity = 1, MediaGuid = Guid.NewGuid(), MediaType = 0, Link = "https://imageio.forbes.com/specials-images/imageserve/5d35eacaf1176b0008974b54/2020-Chevrolet-Corvette-Stingray/0x0.jpg?format=jpg&crop=4560,2565,x790,y784,safe&width=960" },
            new Media() { Id = 2, EntityId = 3, Entity = 1, MediaGuid = Guid.NewGuid(), MediaType = 0, Link = "https://carwow-uk-wp-3.imgix.net/18015-MC20BluInfinito-scaled-e1666008987698.jpg" },
            new Media() { Id = 3, EntityId = 4, Entity = 1, MediaGuid = Guid.NewGuid(), MediaType = 0, Link = "https://cdn.motor1.com/images/mgl/JO94P6/s1/most-expensive-cars-in-the-world.jpg" },
            new Media() { Id = 4, EntityId = 5, Entity = 1, MediaGuid = Guid.NewGuid(), MediaType = 0, Link = "https://carwow-uk-wp-3.imgix.net/18015-MC20BluInfinito-scaled-e1666008987698.jpg" }
            );

        }

    }
}
