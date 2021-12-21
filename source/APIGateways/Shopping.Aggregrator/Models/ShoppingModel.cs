using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Aggregrator.Models
{
    public class ShoppingModel
    {
        public string Username { get; set; }
        public Basket BasketWithProducts { get; set; }
        public IEnumerable<OrderResponse> Orders { get; set; }
    }
}
