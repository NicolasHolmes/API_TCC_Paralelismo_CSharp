using APITCC.Models;
using APITCC.Models.SQLEntity;
using APITCC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APITCC.Repositories
{
    public class ProductDetailRepository : IProductDetailRepository
    {
        private readonly ProductDetailContext _context;
        public ProductDetailRepository(ProductDetailContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ProductDetailRequest>> Get()
        {
            return await _context.ProductDetail.ToListAsync();
        }

        public async Task<ProductDetailRequest> Get(int id)
        {
            return await _context.ProductDetail.FindAsync(id);
        }

        public async Task<ProductDetailRequest> Create(ProductDetailRequest productDetail)
        {
            _context.ProductDetail.Add(productDetail);
            await _context.SaveChangesAsync();
            return productDetail;
        }
    }
}
