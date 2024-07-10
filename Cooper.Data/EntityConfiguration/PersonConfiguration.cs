using Cooper.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cooper.Data.EntityConfiguration
{
    public class PersonConfiguration:IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> personBuilder)
        {
            personBuilder.HasKey(x => x.Id);
            personBuilder.Property(x => x.Id).IsRequired();

        }
    }
}
