using Shopping.Aggregrator.Extensions;
using Shopping.Aggregrator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Shopping.Aggregrator.Services
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
            var response = await _client.GetAsync($"/api/v1/Order/{username}");
            return await response.ReadContentAs<List<OrderResponse>>();
        }
    }
}
