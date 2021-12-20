using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Aggregrator.Models
{
    public class Basket
    {
        public string Username { get; set; }
        public List<BasketItemExtended> Items { get; set; } = new List<BasketItemExtended>();
        public decimal TotalPrice { get; set; }
    }
}
