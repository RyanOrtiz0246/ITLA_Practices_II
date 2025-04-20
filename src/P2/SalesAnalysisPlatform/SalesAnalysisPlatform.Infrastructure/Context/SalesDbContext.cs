using Microsoft.EntityFrameworkCore;
using SalesAnalysisPlatform.Domain.Entities;

namespace SalesAnalysisPlatform.Infrastructure.Context
{
    public class SalesDbContext : DbContext
    {
        public SalesDbContext(DbContextOptions<SalesDbContext> options) : base(options) { }

        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sale>().ToTable("SALES", "RYAN_ORTIZ");

            modelBuilder.Entity<Sale>().Property(s => s.Id).HasColumnName("ID");
            modelBuilder.Entity<Sale>().Property(s => s.ProductName).HasColumnName("PRODUCTNAME");
            modelBuilder.Entity<Sale>().Property(s => s.Price).HasColumnName("PRICE");
            modelBuilder.Entity<Sale>().Property(s => s.Quantity).HasColumnName("QUANTITY");
            modelBuilder.Entity<Sale>().Property(s => s.SaleDate).HasColumnName("SALEDATE");
        }
    }
}
