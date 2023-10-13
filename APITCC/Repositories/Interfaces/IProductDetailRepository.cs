using APITCC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APITCC.Repositories.Interfaces
{
    public interface IProductDetailRepository
    {
        Task<IEnumerable<ProductDetailRequest>> Get();
        Task<ProductDetailRequest> Get(int id);
        Task<ProductDetailRequest> Create(ProductDetailRequest product);
    }
}
