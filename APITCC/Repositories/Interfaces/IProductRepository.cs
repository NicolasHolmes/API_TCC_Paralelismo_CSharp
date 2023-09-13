using APITCC.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APITCC.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductRequest>> Get();
        Task<ProductRequest> Get(int id);
    }
}
