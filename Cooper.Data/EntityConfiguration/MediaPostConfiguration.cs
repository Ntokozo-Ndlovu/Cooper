using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cooper.Data.Entity;

namespace Cooper.Data.EntityConfiguration
{

    public class MediaPostConfiguration : IEntityTypeConfiguration<MediaPost>
    {
        public MediaPostConfiguration(){}
        public void Configure(EntityTypeBuilder<MediaPost> mediaPostBuilder)
        {
            mediaPostBuilder.HasKey(x => x.Id);
            mediaPostBuilder.Property(x => x.Id).IsRequired();

            mediaPostBuilder.Property(x => x.PostId).IsRequired();
            mediaPostBuilder.Property(x => x.MediaId).IsRequired();
            
            this.CreateSeedData(mediaPostBuilder);
     }

        private void CreateSeedData(EntityTypeBuilder<MediaPost> mediaPostBuilder)
        {

            mediaPostBuilder.HasData(new MediaPost() { Id = 1, PostId = 1, MediaId = 1 },
                        new MediaPost() { Id = 2, PostId = 1, MediaId = 2 },
                        new MediaPost() { Id = 3, PostId = 2, MediaId = 3 },
                        new MediaPost() { Id = 4, PostId = 4, MediaId = 4 },
                        new MediaPost() { Id = 5, PostId = 5, MediaId = 5 },
                        new MediaPost() { Id = 6, PostId = 3, MediaId = 6 },
                        new MediaPost() { Id = 7, PostId = 2, MediaId = 7 },
                        new MediaPost() { Id = 8, PostId = 3, MediaId = 8 },
                        new MediaPost() { Id = 9, PostId = 1, MediaId = 9 },
                        new MediaPost() { Id = 10, PostId = 5, MediaId = 10 });
        }
    }

}
