using System.Collections.Generic;

namespace Shopping.Aggregrator.Models
{
    public class ShoppingModel
    {
        public string Username { get; set; }
        public Basket BasketWithProducts { get; set; }
        public IEnumerable<OrderResponse> Orders { get; set; }
    }
}
