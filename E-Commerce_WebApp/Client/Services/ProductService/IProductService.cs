namespace E_Commerce_WebApp.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action OnProductsChanged;
        List<Product> Products { get; set; }
        Task GetProductsAsync(string? categoryUrl = null);
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
    }
}
