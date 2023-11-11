using BusinessObject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DailyNews.BusinessObject.DataContext
{
    public class DailyNewsContext : IdentityDbContext<Member>
    {
        public DailyNewsContext() { }
        public DailyNewsContext(DbContextOptions<DailyNewsContext> options) : base(options)
        {
            Database.Migrate();
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Member> Members { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = @"Server=localhost;Database=Daily_News;user=sa;password=123;TrustServerCertificate=True";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
