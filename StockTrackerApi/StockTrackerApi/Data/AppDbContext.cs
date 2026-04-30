using Microsoft.EntityFrameworkCore;
using StockTrackerApi.Models;

namespace StockTrackerApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {}
        public DbSet<StockPrice> StockPrices { get; set; }
    }
}

