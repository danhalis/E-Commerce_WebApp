namespace E_Commerce_WebApp.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        Task<ServiceResponse<List<Product>>> GetProductsAsync(string categoryUrl);
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
    }
}
