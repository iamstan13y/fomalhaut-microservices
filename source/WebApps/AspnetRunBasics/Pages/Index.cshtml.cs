using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shopping.Web.Models;
using Shopping.Web.Services;

namespace Shopping.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICatalogService _catalogService;
        private readonly IBasketService _basketService;

        public IndexModel(ICatalogService catalogService, IBasketService basketService)
        {
            _catalogService = catalogService ?? throw new ArgumentNullException(nameof(catalogService));
            _basketService = basketService ?? throw new ArgumentNullException(nameof(basketService));
        }

        public IEnumerable<Catalog> ProductList { get; set; } = new List<Catalog>();

        public async Task<IActionResult> OnGetAsync()
        {
            ProductList = await _catalogService.GetCatalog();
            return Page();
        }

        public async Task<IActionResult> OnPostAddToCartAsync(string productId)
        {
            var product = await _catalogService.GetCatalog(productId);

            var basket = await _basketService.GetBasket("juliet");

            basket.Items.Add(new BasketItem
            {
                ProductId = product.Id,
                Color = "Blue",
                Price = product.Price,
                Quantity = 1,
                ProductName = product.Name
            });

            var updatedBasket = await _basketService.UpdateBasket(basket);

            return RedirectToPage("Cart");      
        }
    }
}
