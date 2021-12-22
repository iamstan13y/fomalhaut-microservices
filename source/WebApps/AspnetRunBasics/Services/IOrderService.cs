using Shopping.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Web.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderResponse>> GetOrdersByUsername(string username);
    }
}
