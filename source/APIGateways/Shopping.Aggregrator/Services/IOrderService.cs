using Shopping.Aggregrator.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shopping.Aggregrator.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderResponse>> GetOrdersByUsername(string username);
    }
}
