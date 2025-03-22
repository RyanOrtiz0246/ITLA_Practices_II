using Microsoft.EntityFrameworkCore;

namespace SalesDataAnalysisPlatformMVC.Data
{
    public class AppDbContext : DbContext
    {
        public  AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Sale> Sales { get; set; }
    }
}
