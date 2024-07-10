using Cooper.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Cooper.Data.EntityConfiguration
{
    public class PasswordConfiguration : IEntityTypeConfiguration<Password>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Password> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.PasswordKey).IsRequired();

        }
    }
}
