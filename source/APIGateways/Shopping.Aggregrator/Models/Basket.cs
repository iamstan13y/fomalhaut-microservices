using System.Collections.Generic;

namespace Shopping.Aggregrator.Models
{
    public class Basket
    {
        public string Username { get; set; }
        public List<BasketItemExtended> Items { get; set; } = new List<BasketItemExtended>();
        public decimal TotalPrice { get; set; }
    }
}
