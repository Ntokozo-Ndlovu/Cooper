using Cooper.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cooper.Data.EntityConfiguration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public AddressConfiguration() { }
        public void Configure(EntityTypeBuilder<Address> addressBuilder)
        {
            addressBuilder.HasKey(x => x.Id);
            addressBuilder.Property(x => x.Id).IsRequired();

            this.CreateSeedData(addressBuilder);
        }

        public void CreateSeedData(EntityTypeBuilder<Address> builder)
        {
            builder.HasData(
            new Address() { Id = 1, StreetName = "user 1 st", Suburb = "user 1 sub", City = "user 1 city", PostalCode = "1021" },
            new Address() { Id = 2, StreetName = "user 2 st", Suburb = "user 2 sub", City = "user 2 city", PostalCode = "1022" });


        }
    }
}
