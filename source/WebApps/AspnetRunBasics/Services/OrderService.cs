using Shopping.Web.Extensions;
using Shopping.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Shopping.Web.Services
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _client;

        public OrderService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<OrderResponse>> GetOrdersByUsername(string username)
        {
            var response = await _client.GetAsync($"/Order/{username}");
            return await response.ReadContentAs<List<OrderResponse>>();
        }
    }
}
