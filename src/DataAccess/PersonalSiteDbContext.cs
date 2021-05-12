using Microsoft.EntityFrameworkCore;
using Models.DataModels;

namespace DataAccess
{
    public class PersonalSiteDbContext : DbContext
    {
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }


        public PersonalSiteDbContext(DbContextOptions<PersonalSiteDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Seed();
        }
    }
}
