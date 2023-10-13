using APITCC.Models;
using APITCC.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MinhaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailController : ControllerBase
    {
        private readonly IProductDetailRepository _productDetailRepository;

        public ProductDetailController(IProductDetailRepository productDetailRepository)
        {
            _productDetailRepository = productDetailRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDetailRequest>> GetProductsAsync()
        {
            return await _productDetailRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDetailRequest>> GetProductsAsync(int id)
        {
            return await _productDetailRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<ProductDetailRequest>> CreateProductsAsync([FromBody] ProductDetailRequest productDetail)
        {
            var newProduct = await _productDetailRepository.Create(productDetail);
            return newProduct;
        }
    }
}