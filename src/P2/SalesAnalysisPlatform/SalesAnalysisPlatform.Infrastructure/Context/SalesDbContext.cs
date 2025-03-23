using Microsoft.EntityFrameworkCore;
using SalesAnalysisPlatform.Domain.Entities;

namespace SalesAnalysisPlatform.Infrastructure.Context
{
    public class SalesDbContext : DbContext
    {
        public SalesDbContext(DbContextOptions<SalesDbContext> options) : base(options) { }

        public DbSet<Sale> Sales { get; set; }
    }
}
