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

            this.CreateSeedData(usernameBuilder);
        }

        public void CreateSeedData(EntityTypeBuilder<User> builder){
            builder.HasData(new User(){ Id = 1, UserName = "user1", PersonId = 1, ContactId = 1, AddressId = 1},
                    new User(){ Id = 2, UserName = "user2", PersonId = 2, ContactId = 2, AddressId = 2}); 
        }
    }
}
