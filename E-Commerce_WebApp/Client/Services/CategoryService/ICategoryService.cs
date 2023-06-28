namespace E_Commerce_WebApp.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }
        Task GetCategoriesAsync();
    }
}
