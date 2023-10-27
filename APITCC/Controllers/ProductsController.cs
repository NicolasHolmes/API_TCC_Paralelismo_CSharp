using APITCC.Models;
using APITCC.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MinhaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("GetProducts")]
        public async Task<IEnumerable<ProductRequest>> GetProductsAsync()
        {
            return await _productRepository.GetListOfProducts();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDetailRequest>> GetProductsAsync(int id)
        {
            return await _productRepository.GetProductDetail(id);
        }

        [HttpGet("GetRequestsQuantity")]
        public async Task<int> GetRequestsQuantityAsync()
        {
            return await _productRepository.GetRequestsQuantityAsync();
        }
    }
}