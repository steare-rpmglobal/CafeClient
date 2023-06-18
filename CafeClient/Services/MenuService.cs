using CafeCommon.Enums;
using CafeCommon.Models;
using Newtonsoft.Json;

namespace CafeClient.Services
{
    public class MenuService : IMenuService
    {
        private readonly List<Drink> _menuItems = new List<Drink>();
        public MenuService()
        {
            _menuItems.Add(new Drink(DrinkType.Cappuccino));
            _menuItems.Add(new Drink(DrinkType.FlatWhite));
            _menuItems.Add(new Drink(DrinkType.Espresso));
            _menuItems.Add(new Drink(DrinkType.Latte));
            _menuItems.Add(new Drink(DrinkType.BlackTea));
            _menuItems.Add(new Drink(DrinkType.EarlGreyTea));
            _menuItems.Add(new Drink(DrinkType.GreenTea));
        }

        public List<Drink> GetMenuItems()
        {
            return _menuItems;
        }
    }

    public interface IMenuService
    {
        List<Drink> GetMenuItems();
    }
}
