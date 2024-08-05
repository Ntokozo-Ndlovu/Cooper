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
            builder.HasAlternateKey(x => x.UserId);


            builder.Property(x => x.PostId).IsRequired();
            builder.HasAlternateKey(x => x.PostId);        
        }
    }
}
