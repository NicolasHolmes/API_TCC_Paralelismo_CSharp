using APITCC.Models;
using APITCC.Models.SQLEntity;
using APITCC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APITCC.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;
        public ProductRepository(ProductContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ProductRequest>> GetListOfProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<ProductDetailRequest> GetProductDetail(int id)
        {
            return await _context.ProductDetail.FindAsync(id);
        }

        public async Task<int> GetRequestsQuantityAsync()
        {
            return await _context.ProductDetail.CountAsync();
        }
    }
}
