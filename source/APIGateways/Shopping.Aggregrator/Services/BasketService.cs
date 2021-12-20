using Shopping.Aggregrator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Aggregrator.Services
{
    public class BasketService : IBasketService
    {
        public Task<Basket> GetBasket(string username)
        {
            throw new NotImplementedException();
        }
    }
}
