using Shopping.Aggregrator.Extensions;
using Shopping.Aggregrator.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Shopping.Aggregrator.Services
{
    public class BasketService : IBasketService
    {
        private readonly HttpClient _client;

        public BasketService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<Basket> GetBasket(string username)
        {
            var response = await _client.GetAsync($"/api/v1/Basket/{username}");
            return await response.ReadContentAs<Basket>();
        }
    }
}
