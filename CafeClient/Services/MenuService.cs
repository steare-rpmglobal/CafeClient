using Newtonsoft.Json;

namespace CafeClient.Services
{
    public class MenuService : IMenuService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public MenuService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<List<Item>> GetMenuItems()
        {
            var menuUrl = _configuration["menuUrl"];

            var responseMessage = await _httpClient.GetStringAsync(menuUrl);
            var items = JsonConvert.DeserializeObject<IEnumerable<Item>>(responseMessage);
            return items?.ToList() ?? new List<Item>();
        }
    }

    public interface IMenuService
    {
        Task<List<Item>> GetMenuItems();
    }
}
