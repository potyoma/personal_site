using Microsoft.EntityFrameworkCore;
using Models.DataModels;

namespace DataAccess
{
    public class PersonalSiteDbContext : DbContext
    {
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Image> Images { get; set; }
        
    }
}
