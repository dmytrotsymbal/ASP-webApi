using ASP_webapi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP_webapi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Hero> Heroes { get; set; } // heroes table
        public DbSet<HeroImage> HeroImages { get; set; } // heroes images table

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Hero>()
                .HasMany(h => h.Images)
                .WithOne(i => i.Hero)
                .HasForeignKey(i => i.HeroId);
        }
    }
}
