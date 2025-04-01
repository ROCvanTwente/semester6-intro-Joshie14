//Jochem

using CSHARP3.Models;
using Microsoft.EntityFrameworkCore;

namespace CSHARP3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CD> CDs { get; set; }
        public DbSet<DVD> DVDs { get; set; }
        public DbSet<Product> Products { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasDiscriminator<string>("ProductType")
                .HasValue<CD>("CD")
                .HasValue<DVD>("DVD");
        }
    }
}
