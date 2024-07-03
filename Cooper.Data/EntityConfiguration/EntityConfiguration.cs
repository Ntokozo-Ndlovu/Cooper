using Cooper.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.Data.EntityConfiguration
{
    public class EntityConfiguration:IEntityTypeConfiguration<Cooper.Data.Entity.Entity>
    {

        public void Configure(EntityTypeBuilder<Cooper.Data.Entity.Entity> entityBuilder)
        {
            entityBuilder.HasKey(e => e.Id);    
            entityBuilder.Property(e => e.Id).IsRequired();
            createSeedData(entityBuilder);
        }


        private void createSeedData(EntityTypeBuilder<Entity.Entity> entityBuilder)
        {
            entityBuilder.HasData(new Entity.Entity() { Id = 1, UUID = Guid.NewGuid() },
                new Entity.Entity() { Id = 12, UUID = Guid.NewGuid() },
                new Entity.Entity() { Id = 13, UUID = Guid.NewGuid() },
                new Entity.Entity() { Id = 14, UUID = Guid.NewGuid() },
                new Entity.Entity() { Id = 15, UUID = Guid.NewGuid() },
                //Media Entity
                new Entity.Entity() { Id = 2, UUID = Guid.NewGuid() },
                new Entity.Entity() { Id = 3, UUID = Guid.NewGuid() },
                new Entity.Entity() { Id = 4, UUID = Guid.NewGuid() },
                new Entity.Entity() { Id = 5, UUID = Guid.NewGuid() },
                new Entity.Entity() { Id = 6, UUID = Guid.NewGuid() },
                new Entity.Entity() { Id = 16, UUID = Guid.NewGuid() },
                new Entity.Entity() { Id = 17, UUID = Guid.NewGuid() },
                new Entity.Entity() { Id = 18, UUID = Guid.NewGuid() },
                new Entity.Entity() { Id = 19, UUID = Guid.NewGuid() },

                //Comment Entities
                new Entity.Entity() { Id = 7, UUID = Guid.NewGuid() },
                new Entity.Entity() { Id = 8, UUID = Guid.NewGuid() },

                //Challenge Entitites
                new Entity.Entity() { Id = 9, UUID = Guid.NewGuid() },
                new Entity.Entity() { Id = 10, UUID = Guid.NewGuid() },
                new Entity.Entity() { Id = 11, UUID = Guid.NewGuid() }
              
                );

        }
    }
}
