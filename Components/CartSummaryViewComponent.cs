using Microsoft.AspNetCore.Mvc;
using Mission9_waltona1.Models;
namespace Mission9_waltona1.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket basket;
        public CartSummaryViewComponent(Basket b)
        {
            basket = b;
        }
        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}
