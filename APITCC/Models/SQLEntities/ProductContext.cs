using Microsoft.EntityFrameworkCore;

namespace APITCC.Models.SQLEntity
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<ProductRequest> Products { get; set; }
    }
}
