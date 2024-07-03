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
    public class UserConfiguration: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> usernameBuilder)
        {
            usernameBuilder.HasKey(x => x.Id);
            usernameBuilder.Property(x => x.Id).IsRequired();

            usernameBuilder.Property(x => x.EntityId).IsRequired();
            usernameBuilder.HasAlternateKey(x => x.EntityId);
        }
    }
}
