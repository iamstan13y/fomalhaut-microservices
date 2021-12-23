using System.Collections.Generic;

namespace Shopping.Web.Models
{
    public class Basket
    {
        public string Username { get; set; }
        public List<BasketItem> Items { get; set; } = new List<BasketItem>();
        public decimal TotalPrice { get; set; }
    }
}
