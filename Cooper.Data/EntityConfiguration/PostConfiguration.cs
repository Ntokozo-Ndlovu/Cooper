using Cooper.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cooper.Data.EntityConfiguration
{
    public class PostConfiguration: IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> postBuilder)
        {
            postBuilder.HasKey(x => x.Id);

            postBuilder.Property(x => x.Id).IsRequired();

            
            postBuilder.Property(x => x.ChallengeId).IsRequired();  


            postBuilder.HasData(new Post { Id = 1 ,Title="Steer Burger", Description = "School Post",   ChallengeId= Guid.Parse("a3bb21c7-9ea2-4c9b-9811-e3526856d05b") },
                new Post { Id = 2, Title = "Ball for Soccer Peeps", Description = "Sport Cars",  ChallengeId = Guid.Parse("520a4d3a-e6ce-458c-8c72-360a5ffc92eb") },
                new Post { Id = 3, Title = "Hello Wold", Description = "Everything we care about",  ChallengeId = Guid.Parse("162ff745-7807-4b06-8660-5c7cc89a392f") },
                new Post { Id = 4, Title = "Mc Donalds", Description = "Best McDonald picture", ChallengeId = Guid.Parse("a3bb21c7-9ea2-4c9b-9811-e3526856d05b") },
                new Post { Id = 5, Title = "King Burger", Description = "King Burger Tastes really good", ChallengeId = Guid.Parse("a3bb21c7-9ea2-4c9b-9811-e3526856d05b") });

        }
    }
}
