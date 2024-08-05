using Cooper.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cooper.Data.EntityConfiguration
{
    public class UserConfiguration: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> usernameBuilder)
        {
            usernameBuilder.HasKey(x => x.Id);
            usernameBuilder.Property(x => x.Id).IsRequired();

        }
    }
}
