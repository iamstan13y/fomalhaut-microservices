using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Web.Models
{
    public class Basket
    {
        public string Username { get; set; }
        public List<BasketItem> Items { get; set; } = new List<BasketItem>();
        public decimal TotalPrice { get; set; }
    }
}
