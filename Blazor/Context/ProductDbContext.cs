using Blazor.Database;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Context
{
    public class ProductDbContext:DbContext
    {
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=BlazorCrud;Trusted_Connection=True");
        }

        public DbSet<Product> Products { get; set; } = default!;
    }
}
