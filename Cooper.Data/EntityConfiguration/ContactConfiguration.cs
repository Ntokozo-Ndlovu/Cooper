using Cooper.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cooper.Data.EntityConfiguration
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(x => x.Id);

            this.CreateSeedData(builder);
        }

        public void CreateSeedData(EntityTypeBuilder<Contact> builder){
        builder.HasData(new Contact(){Id=1, Email="user1@cooper.com", PhoneNumber="078944599345"},
                new Contact(){ Id = 2, Email =" user2@cooper.com", PhoneNumber="068004599345"});

        }
    }
}
