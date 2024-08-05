using Cooper.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cooper.Data.EntityConfiguration
{
    public class AddressConfiguration:IEntityTypeConfiguration<Address>
    {
        public AddressConfiguration() { }
        public void Configure(EntityTypeBuilder<Address> addressBuilder)
        {
            addressBuilder.HasKey(x => x.Id);  
            addressBuilder.Property(x => x.Id).IsRequired();

        }
    }
}
