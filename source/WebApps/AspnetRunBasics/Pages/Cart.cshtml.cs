using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shopping.Web.Models;
using Shopping.Web.Services;

namespace Shopping.Web.Pages
{
    public class CartModel : PageModel
    {
        private readonly IBasketService _basketService;

        public CartModel(IBasketService basketService)
        {
            _basketService = basketService ?? throw new ArgumentNullException(nameof(basketService));
        }

        public Basket Cart { get; set; } = new Basket();        

        public async Task<IActionResult> OnGetAsync()
        {
            Cart = await _basketService.GetBasket("juliet");            

            return Page();
        }

        public async Task<IActionResult> OnPostRemoveToCartAsync(string productId)
        {
            var basket = await _basketService.GetBasket("juliet");

            var item = basket.Items.Single(x => x.ProductId == productId);
            basket.Items.Remove(item);

            var updatedBasket = await _basketService.UpdateBasket(basket);

            return RedirectToPage();
        }
    }
}