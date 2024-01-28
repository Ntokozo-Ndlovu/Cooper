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
                new Challenge() {Id=1, Name = "Best Soccer Picture",Price= 11 , Description="Please take a good soccer photo", ChallengeGuid = Guid.Parse("162ff745-7807-4b06-8660-5c7cc89a392f"),EntityId= 9 }, 
                new Challenge() {Id=2, Name = "Best Steers Picture",Price = 12, Description = "Please take a nice picture eating out",ChallengeGuid = Guid.Parse("520a4d3a-e6ce-458c-8c72-360a5ffc92eb"), EntityId= 10},
                new Challenge() {Id=3, Name = "Best Sunday Chill Picture", Price = 13, Description = "Please take a nice picture eating out", ChallengeGuid = Guid.Parse("a3bb21c7-9ea2-4c9b-9811-e3526856d05b"), EntityId=11});
        }
    }


  

}
