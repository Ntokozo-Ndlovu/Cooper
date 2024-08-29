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

            commentBuilder.HasData(new Comment() { Id = 1, Title = "Comment 1", Body = "You are the best" },
                new Comment() { Id = 2, Title = "Comment 2 ", Body = "You are the best" },
                new Comment() { Id = 3, Title = "Comment 3 ", Body = "You are the best" },
                new Comment() { Id = 4, Title = "Comment 4 ", Body = "You are the best" },
                new Comment() { Id = 5, Title = "Comment 5 ", Body = "You are the best" },
                new Comment() { Id = 6, Title = "Comment 6 ", Body = "You are the best" },
                new Comment() { Id = 7, Title = "Comment 7 ", Body = "You are the best" },
                new Comment() { Id = 8, Title = "Comment 8 ", Body = "You are the best" },
                new Comment() { Id = 9, Title = "Comment 9 ", Body = "You are the best" },
                new Comment() { Id = 10, Title = "Comment 10 ", Body = "You are the best" },
                new Comment() { Id = 11, Title = "Comment 11 ", Body = "You are the best" },
                new Comment() { Id = 12, Title = "Comment 12 ", Body = "You are the best" },
                new Comment() { Id = 13, Title = "Comment 13 ", Body = "You are the best" },
                new Comment() { Id = 14, Title = "Comment 14 ", Body = "You are the best" },
                new Comment() { Id = 15, Title = "Comment 15 ", Body = "You are the best" },
                new Comment() { Id = 16, Title = "Comment 16 ", Body = "You are the best" }
                );



        }
    }
}
