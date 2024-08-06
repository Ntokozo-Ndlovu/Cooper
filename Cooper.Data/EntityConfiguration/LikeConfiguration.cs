using Cooper.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cooper.Data.EntityConfiguration
{
    public class LikeConfiguration : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();


            builder.Property(x => x.UserId).IsRequired();


            builder.Property(x => x.PostId).IsRequired();

            this.CreateSeedData(builder);
        }

        private void CreateSeedData(EntityTypeBuilder<Like> builder)
        {
            builder.HasData(new Like() { Id = 1, UserId = 1, PostId = 1 },
                    new Like() { Id = 2, UserId = 2, PostId = 1 },
                    new Like() { Id = 3, UserId = 1, PostId = 3 },
                    new Like() { Id = 4, UserId = 1, PostId = 5 },
                    new Like() { Id = 5, UserId = 2, PostId = 5 },
                    new Like() { Id = 6, UserId = 1, PostId = 2 }
                    );
        }
    }
}
