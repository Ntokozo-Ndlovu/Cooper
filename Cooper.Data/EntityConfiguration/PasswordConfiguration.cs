using Cooper.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Cooper.Data.EntityConfiguration
{
    public class PasswordConfiguration : IEntityTypeConfiguration<Password>
    {
        public void Configure(EntityTypeBuilder<Password> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.PasswordKey).IsRequired();

            this.CreateSeedData(builder);
        }

        public void CreateSeedData(EntityTypeBuilder<Password> builder){
            builder.HasData(new Password(){Id = 1, PasswordKey= "string1", UserId= 1},
                new Password(){Id =2, PasswordKey ="string2", UserId =2});
        }
    }
}
