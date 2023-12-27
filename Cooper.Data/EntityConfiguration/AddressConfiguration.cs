using Cooper.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.Data.EntityConfiguration
{
    public class AddressConfiguration:IEntityTypeConfiguration<Address>
    {
        public AddressConfiguration() { }
        public void Configure(EntityTypeBuilder<Address> addressBuilder)
        {
            addressBuilder.HasKey(x => x.Id);  
            addressBuilder.Property(x => x.Id).IsRequired();

            addressBuilder.Property(x => x.EntityId).IsRequired();
            addressBuilder.HasAlternateKey(x => x.EntityId);
        }
    }
}
