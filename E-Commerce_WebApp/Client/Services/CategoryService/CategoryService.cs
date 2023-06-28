using E_Commerce_WebApp.Shared;
using System.Net.Http.Json;

namespace E_Commerce_WebApp.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public CategoryService(HttpClient http)
        {
            _http = http;
        }

        public List<Category> Categories { get; set; } = new List<Category>();

        public async Task GetCategoriesAsync()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/categories");
            if (result != null && result.Data != null)
                Categories = result.Data;
        }
    }
}
