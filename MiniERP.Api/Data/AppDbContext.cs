using Microsoft.EntityFrameworkCore;
using BorealERP.Api.Entities;

namespace BorealERP.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .ToTable("customers");
            modelBuilder.Entity<User>()
                .ToTable("users");

            base.OnModelCreating(modelBuilder);
        }


    }
}
