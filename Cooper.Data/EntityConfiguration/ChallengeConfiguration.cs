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
        
            createSeedData(challengeBuilder);
        }

        public void createSeedData(EntityTypeBuilder<Challenge> builder)
        {
            builder.HasData(
                new Challenge() {Id=1, Name = "Best Soccer Picture",Price= 11 , Description="Please take a good soccer photo", ChallengeGuid = Guid.NewGuid(),EntityId= 9 }, 
                new Challenge() {Id=2, Name = "Best Steers Picture",Price = 12, Description = "Please take a nice picture eating out",ChallengeGuid = Guid.NewGuid() ,EntityId= 10},
                new Challenge() {Id=3, Name = "Best Sunday Chill Picture", Price = 13, Description = "Please take a nice picture eating out", ChallengeGuid = Guid.NewGuid() ,EntityId=11});
        }
    }


  

}
