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
    public class PostConfiguration: IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> postBuilder)
        {
            postBuilder.HasKey(x => x.Id);
            postBuilder.Property(x => x.Id).IsRequired();

            postBuilder.Property(x => x.EntityId).IsRequired();
            postBuilder.HasAlternateKey(x => x.EntityId);
        }
    }
}
