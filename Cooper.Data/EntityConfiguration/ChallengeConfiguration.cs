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
    public class ChallengeConfiguration : IEntityTypeConfiguration<Challenge>
    {
        public void Configure(EntityTypeBuilder<Challenge> challengeBuilder)
        {
            challengeBuilder.HasKey(props => props.Id);
            challengeBuilder.Property(props => props.Id).IsRequired();

            challengeBuilder.Property(x => x.EntityId).IsRequired();
            challengeBuilder.HasAlternateKey(x => x.EntityId);
        }
    }
}
