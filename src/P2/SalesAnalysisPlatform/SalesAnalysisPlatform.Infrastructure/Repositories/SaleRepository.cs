using SalesAnalysisPlatform.Domain.Entities;
using SalesAnalysisPlatform.Infrastructure.Interfaces;
using SalesAnalysisPlatform.Infrastructure.Core;
using SalesAnalysisPlatform.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace SalesAnalysisPlatform.Infrastructure.Repositories
{
    public class SaleRepository : BaseRepository<Sale>, ISaleRepository
    {
        private readonly SalesDbContext _context;

        public SaleRepository(SalesDbContext context)
        {
            _context = context;
        }

        // Implementación de GetAllSalesAsync
        public async Task<IEnumerable<Sale>> GetAllSalesAsync()
        {
            return await _context.Sales.ToListAsync();
        }

        // Implementación de GetSaleByIdAsync
        public async Task<Sale> GetSaleByIdAsync(int id)
        {
            return await _context.Sales.FindAsync(id);
        }

        // Implementación de AddSaleAsync
        public async Task AddSaleAsync(Sale sale)
        {
            await _context.Sales.AddAsync(sale);
            await _context.SaveChangesAsync();
        }

        // Implementación de UpdateSaleAsync
        public async Task UpdateSaleAsync(Sale sale)
        {
            _context.Sales.Update(sale);
            await _context.SaveChangesAsync();
        }

        // Implementación de DeleteSaleAsync
        public async Task DeleteSaleAsync(int id)
        {
            var sale = await _context.Sales.FindAsync(id);
            if (sale != null)
            {
                _context.Sales.Remove(sale);
                await _context.SaveChangesAsync();
            }
        }
    }
}
