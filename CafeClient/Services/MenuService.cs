using Newtonsoft.Json;

namespace CafeClient.Services
{
    public class MenuService : IMenuService
    {
        private readonly HttpClient _httpClient;

        public MenuService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Item>> GetMenuItems()
        {
            var responseMessage = await _httpClient.GetStringAsync("http://localhost:7015/api/Menu");
            var items = JsonConvert.DeserializeObject<IEnumerable<Item>>(responseMessage);
            return items?.ToList() ?? new List<Item>();
        }
    }

    public interface IMenuService
    {
        Task<List<Item>> GetMenuItems();
    }
}
