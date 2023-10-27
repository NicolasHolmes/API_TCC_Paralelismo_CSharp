using APITCC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APITCC.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductRequest>> GetListOfProducts();
        Task<ProductDetailRequest> GetProductDetail(int id);
        Task<int> GetRequestsQuantityAsync();
    }
}
