using Cooper.Data.Entity;
using Cooper.Data.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.Data
{
    public class CooperDbContext:DbContext
    {
        public CooperDbContext() : base()
        {

        }
        public CooperDbContext(DbContextOptions<CooperDbContext> options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //build a connection string
            var configBuild= new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false);
            IConfiguration config = configBuild.Build();
            //get the connection String;

            string connectionString = config.GetConnectionString("DefaultConnection");
            builder.UseNpgsql(connectionString);
            Console.Write(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new ChallengeConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new Cooper.Data.EntityConfiguration.EntityConfiguration());
            modelBuilder.ApplyConfiguration(new MediaConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new UsernameConfiguration());

            //Configuring relationships

        }

        public DbSet<Address> Address {  get; set; }
        public DbSet<Challenge> Challenge { get; set; }
        public DbSet<Cooper.Data.Entity.Entity> Entities { get; set; }
        public DbSet<Media> Media { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Username> Username { get; set; }
        public DbSet<Comment> Comment { get; set; }

    }
}
