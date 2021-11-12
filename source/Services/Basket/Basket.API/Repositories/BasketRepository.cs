using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Distributed;
using Basket.API.Models;
using Newtonsoft.Json;

namespace Basket.API.Repositories
{
    public class BasketRepository : IBasketRepository
    {
        private readonly IDistributedCache _redisCache;

        public BasketRepository(IDistributedCache redisCache)
        {
            _redisCache = redisCache ?? throw new ArgumentNullException(nameof(redisCache));
        }

        public async Task<ShoppingCart> GetBasket(string username)
        {
            var basket = await _redisCache.GetStringAsync(username);
            if (string.IsNullOrEmpty(basket))
                return null;

            return JsonConvert.DeserializeObject<ShoppingCart>(basket);
        }

        public async Task<ShoppingCart> UpdateBasket(ShoppingCart basket)
        {
            await _redisCache.SetStringAsync(basket.Username, JsonConvert.SerializeObject(basket));
            
            return await GetBasket(basket.Username);
        }

        public async Task DeleteBasket(string username)
        {
            await _redisCache.RemoveAsync(username);
        }
    }
}
