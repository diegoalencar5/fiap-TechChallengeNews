using Microsoft.EntityFrameworkCore;
using News.ApplicationCore.Entities;

namespace News.ApplicationCore.Data
{
    public class ApiSecurityDbContext : DbContext
    {
        public ApiSecurityDbContext(DbContextOptions<ApiSecurityDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> User { get; set; }

    }
}
