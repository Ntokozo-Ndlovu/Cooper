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
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> commentBuilder)
        {
            commentBuilder.HasKey(x => x.Id);
            commentBuilder.Property(x => x.Id).IsRequired();

            commentBuilder.Property(x => x.EntityId).IsRequired();
            commentBuilder.HasAlternateKey(x => x.EntityId);

            createSeedData(commentBuilder);
        }

        private void createSeedData(EntityTypeBuilder<Comment> commentBuilder)
        {

            commentBuilder.HasData(new Comment() { Id = 1 ,Entity= 1,EntityId = 7, Body="You are the best"},
                new Comment() { Id = 2, Entity = 1, EntityId = 8, Body = "You are the best" }
                );



        }
    }
}
