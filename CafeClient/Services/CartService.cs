using System.Text;
using System.Text.Json;
using CafeCommon.Models;
using Newtonsoft.Json;

namespace CafeClient.Services
{
    public class CartService
    {
        private readonly Order _myOrder;
        private readonly string? orderServiceUrl;

        public CartService(IConfiguration configuration, Order myOrder)
        {
            this.orderServiceUrl = configuration.GetValue<string>("orderUrl");
            _myOrder = myOrder;
        }

        public async Task SubmitOrder()
        {
            _myOrder.CreatedDate = DateTime.UtcNow;

            // Post order to order service.
            if (this.orderServiceUrl != null)
            {
                using var httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(this.orderServiceUrl);
                await httpClient.PostAsJsonAsync("Orders", _myOrder);

                //Clear Order details after submitting order.
            }
        }

        public void ClearCart()
        {
            _myOrder.Drinks.Clear();
        }

        public void AddToCart(Drink drink)
        {
            _myOrder.Drinks.Add(drink);
        }

        public Order GetOrder()
        {
            return _myOrder;
        }
    }
}
