using E_Commerce_WebApp.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_WebApp.Server.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
            var serviceResponse = await _productService.GetProductsAsync();
            return Ok(serviceResponse);
        }

        [HttpGet("query")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts(string categoryUrl)
        {
            var serviceResponse = await _productService.GetProductsAsync(categoryUrl);
            return Ok(serviceResponse);
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProduct(int productId)
        {
            var serviceResponse = await _productService.GetProductAsync(productId);
            return Ok(serviceResponse);
        }
    }
}
