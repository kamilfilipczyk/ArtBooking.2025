
using Buisness.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Buisness.Model.Data
{
    public class ArtBookingDbContext : DbContext
    {
        public ArtBookingDbContext(DbContextOptions<ArtBookingDbContext> options) : base(options)
        {
            
        }

        public DbSet<ArtOrganization> ArtOrganizations { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<ArtOrganization>().HasKey(o => o.Id);
        }
    }
}
