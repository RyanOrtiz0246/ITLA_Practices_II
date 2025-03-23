using Microsoft.EntityFrameworkCore;
using SalesAnalysisPlatform.Application.Interfaces;
using SalesAnalysisPlatform.Application.Services;
using SalesAnalysisPlatform.Infrastructure.Context;
using SalesAnalysisPlatform.Infrastructure.IOC;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration.GetConnectionString("OracleDb"));

builder.Services.AddDbContext<SalesDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("OracleDb"))
          .EnableSensitiveDataLogging()
          .LogTo(Console.WriteLine, LogLevel.Information));

builder.Services.AddScoped<ISaleService, SaleService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Sales}/{action=Index}/{id?}");

app.Run();
