using Microsoft.EntityFrameworkCore;
using Ordering.Application.Contracts.Persistence;
using Ordering.Domain.Models;
using Ordering.Infrastructure.Persistence;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(OrderContext context) : base(context)
        {

        }
        public async Task<IEnumerable<Order>> GetOrdersByUsername(string username)
        {
            var orderList = await _context.Orders
                                          .Where(o => o.UserName == username)
                                          .ToListAsync();

            return orderList;
        }
    }
}
