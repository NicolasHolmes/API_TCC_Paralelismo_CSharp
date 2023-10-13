using Microsoft.EntityFrameworkCore;

namespace APITCC.Models.SQLEntity
{
    public class ProductDetailContext : DbContext
    {
        public ProductDetailContext(DbContextOptions<ProductDetailContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<ProductDetailRequest> ProductDetail { get; set; }
    }
}
