using Shopping.Web.Models;
using System.Threading.Tasks;

namespace Shopping.Web.Services
{
    public interface IBasketService
    {
        Task<Basket> GetBasket(string username);
        Task<Basket> UpdateBasket(Basket basket);
        Task CheckoutBasket(BasketCheckout basket);
    }
}
