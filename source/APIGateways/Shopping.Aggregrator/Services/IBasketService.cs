using Shopping.Aggregrator.Models;
using System.Threading.Tasks;

namespace Shopping.Aggregrator.Services
{
    public interface IBasketService
    {
        Task<Basket> GetBasket(string username);
    }
}
