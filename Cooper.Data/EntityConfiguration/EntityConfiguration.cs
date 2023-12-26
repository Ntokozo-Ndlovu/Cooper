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

        }
    }
}
