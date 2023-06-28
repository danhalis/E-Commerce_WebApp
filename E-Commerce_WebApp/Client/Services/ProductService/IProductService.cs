namespace E_Commerce_WebApp.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task GetProducts();
    }
}
