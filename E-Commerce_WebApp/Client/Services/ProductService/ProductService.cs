using E_Commerce_WebApp.Shared;
using System.Net.Http.Json;

namespace E_Commerce_WebApp.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public event Action OnProductsChanged;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public List<Product> Products { get; set; } = new List<Product>();

        public async Task GetProductsAsync(string? categoryUrl = null)
        {
            var result = categoryUrl == null ?
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/products")
                :
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/products/query?categoryUrl={categoryUrl}");
            if (result != null && result.Data != null)
                Products = result.Data;

            OnProductsChanged.Invoke();
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/products/{productId}");
            return result;
        }
    }
}
