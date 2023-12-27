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
    public class PersonConfiguration:IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> personBuilder)
        {
            personBuilder.HasKey(x => x.Id);
            personBuilder.Property(x => x.Id).IsRequired();

            personBuilder.Property(x => x.EntityId).IsRequired();
            personBuilder.HasAlternateKey(x => x.EntityId);
        }
    }
}
