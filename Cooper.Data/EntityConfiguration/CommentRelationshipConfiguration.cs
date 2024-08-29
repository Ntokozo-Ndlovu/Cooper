using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cooper.Data.Entity;



namespace Cooper.Data.EntityConfiguration
{

    public class CommentRelationshipConfiguration : IEntityTypeConfiguration<CommentRelationship>
    {
        public void Configure(EntityTypeBuilder<CommentRelationship> commentRBuilder)
        {
            commentRBuilder.HasKey(x => x.Id);
            this.CreateSeedData(commentRBuilder);
        }

        public void CreateSeedData(EntityTypeBuilder<CommentRelationship> builder)
        {
            builder.HasData(
                new CommentRelationship() { Id = 1, ParentId = 0, PostId= 3 },

                new CommentRelationship() { Id = 2, ParentId = 0, PostId = 3 },

                new CommentRelationship() { Id = 3, ParentId = 1, PostId = 3 },

                new CommentRelationship() { Id = 4, ParentId = 2, PostId = 3 },

               new CommentRelationship() { Id = 5, ParentId = 1, PostId = 3 },

               new CommentRelationship() { Id = 6, ParentId = 1, PostId = 3 },

               new CommentRelationship() { Id = 7, ParentId = 5, PostId = 3 },

               new CommentRelationship() { Id = 8, ParentId = 5, PostId = 3 },

               new CommentRelationship() { Id = 9, ParentId = 4, PostId = 3 },

               new CommentRelationship() { Id = 10, ParentId = 4, PostId = 3 },

               new CommentRelationship() { Id = 11, ParentId = 4, PostId = 3 },

               new CommentRelationship() { Id = 12, ParentId = 4, PostId = 3 },

               new CommentRelationship() { Id = 13, ParentId = 12, PostId = 3 },

               new CommentRelationship() { Id = 14, ParentId = 13, PostId= 3 },

               new CommentRelationship() { Id = 15, ParentId = 12, PostId = 3 },

               new CommentRelationship() { Id = 16, ParentId = 4, PostId = 3 }

                    );

        }
    }

}
