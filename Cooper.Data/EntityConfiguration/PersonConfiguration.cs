using Cooper.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cooper.Data.EntityConfiguration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> personBuilder)
        {
            personBuilder.HasKey(x => x.Id);
            personBuilder.Property(x => x.Id).IsRequired();

            this.CreateSeedData(personBuilder);
        }

        public void CreateSeedData(EntityTypeBuilder<Person> personBuilder)
        {
            personBuilder.HasData(
                    new Person(){ Id = 1, Name = "user 1", Surname = "surname1" , Age = 12, Gender = "male" }, 
                    new Person(){Id = 2, Name = "user 2", Surname = "surname2" , Age = 14, Gender = "female"});

        }
    }
}
