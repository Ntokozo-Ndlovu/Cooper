using Cooper.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cooper.Data.EntityConfiguration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> commentBuilder)
        {
            commentBuilder.HasKey(x => x.Id);
            commentBuilder.Property(x => x.Id).IsRequired();


            createSeedData(commentBuilder);
        }

        private void createSeedData(EntityTypeBuilder<Comment> commentBuilder)
        {

            commentBuilder.HasData(new Comment() { Id = 1 ,Title ="Comment 1", Body="You are the best"},
                new Comment() { Id = 2, Title = "Comment 2 ",Body = "You are the best" }
                );



        }
    }
}
