using CafeClient.Models;
using Newtonsoft.Json;

namespace CafeClient.Services
{
    public class MenuService : IMenuService
    {
        private List<Item> _menuItems = new List<Item>();
        public MenuService()
        {
            _menuItems.Add(new Item(1, "Cappuccino", "https://hips.hearstapps.com/hmg-prod/images/directly-above-shot-of-cappuccino-served-on-table-royalty-free-image-769817517-1564602749.jpg"));
            _menuItems.Add(new Item(2, "Flat White", "https://d3vueie8hikq61.cloudfront.net/wp-content/uploads/2018/02/latte-vs-flat-white.jpg"));
            _menuItems.Add(new Item(3, "Espresso", "https://d9pl0lig74xnv.cloudfront.net/catalog/product/cache/91e9c011f0ac998e686df01a906b8401/1/0/10602-10_a_1.jpg"));
            _menuItems.Add(new Item(4, "Cafe latte", "https://coffeeaffection.com/wp-content/uploads/2020/01/how-to-make-a-latte-at-home.webp"));
            _menuItems.Add(new Item(5, "Black Tea", "https://cdn.intelligencebank.com/au/share/NOrD/1VN0z/ZX8GD/preset=pB6BA/T125AE008_chai_brewed_loose_leaf"));
            _menuItems.Add(new Item(6, "Earl Grey Tea", "https://cdn.intelligencebank.com/au/share/NOrD/1VN0z/en7JL/preset=pB6BA/B125AE018_french_earl_grey_teabag_lifestyle"));
            _menuItems.Add(new Item(7, "Green Tea", "https://cdn.shopify.com/s/files/1/0253/2553/5337/products/green_tea_b2b5b32f-1f04-44d8-8f01-f960b29b1be2_600x_crop_center.jpg?v=1568194793"));
        }

        public List<Item> GetMenuItems()
        {
            return _menuItems;
        }
    }

    public interface IMenuService
    {
        List<Item> GetMenuItems();
    }
}
