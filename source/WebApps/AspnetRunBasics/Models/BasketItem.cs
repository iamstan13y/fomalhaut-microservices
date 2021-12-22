using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Web.Models
{
    public class BasketItem
    {
        public int Quantity { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
