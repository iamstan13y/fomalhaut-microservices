using Shopping.Aggregrator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Aggregrator.Services
{
    public class OrderService : IOrderService
    {
        public Task<IEnumerable<OrderResponse>> GetOrdersByUsername(string username)
        {
            throw new NotImplementedException();
        }
    }
}
