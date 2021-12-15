using Microsoft.EntityFrameworkCore;
using Project_Work.Models;

namespace Project_Work.Context
{
    class InternetContext : DbContext
    {
        public DbSet<InternetResource> Resources { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserResource> UsersResources { get; set; }

        public InternetContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=InternetResourcesVisited;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserResource>().HasKey(sc => new { sc.ResourceId, sc.UserId });
        }
    }
}