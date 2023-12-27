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
    public class MediaConfiguration: IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> mediaBuilder)
        {
            mediaBuilder.HasKey(x => x.Id);
            mediaBuilder.Property(x => x.EntityId).IsRequired();

            mediaBuilder.Property(x => x.EntityId).IsRequired();
            mediaBuilder.HasAlternateKey(x => x.EntityId);
        }

    }
}
