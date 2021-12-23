using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shopping.Web.Models;
using Shopping.Web.Services;

namespace Shopping.Web.Pages
{
    public class CheckOutModel : PageModel
    {
        private readonly IBasketService _basketService;
        private readonly IOrderService _orderService;

        public CheckOutModel(IBasketService basketService, IOrderService orderService)
        {
            _basketService = basketService ?? throw new ArgumentNullException(nameof(basketService));
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
        }

        [BindProperty]
        public BasketCheckout Order { get; set; }

        public Basket Cart { get; set; } = new Basket();

        public async Task<IActionResult> OnGetAsync()
        {
            Cart = await _basketService.GetBasket("juliet");
            return Page();
        }

        public async Task<IActionResult> OnPostCheckOutAsync()
        {
            Cart = await _basketService.GetBasket("juliet");

            if (!ModelState.IsValid)
            {
                return Page();
            }

            Order.UserName = "juliet";
            Order.TotalPrice = Cart.TotalPrice;

            await _basketService.CheckoutBasket(Order);
            
            return RedirectToPage("Confirmation", "OrderSubmitted");
        }       
    }
}