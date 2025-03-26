using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesAnalysisPlatform.Domain.Repositories;
using SalesAnalysisPlatform.Infrastructure.Context;
using SalesAnalysisPlatform.Infrastructure.Repositories;
using SalesAnalysisPlatform.Application.Interfaces;
using SalesAnalysisPlatform.Application.Services;

namespace SalesAnalysisPlatform.Infrastructure.IOC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<SalesDbContext>(options =>
                options.UseOracle(connectionString));

            services.AddScoped<ISaleRepository, SaleRepository>();
            services.AddScoped<ISaleService, SaleService>();

            return services;
        }
    }
}
