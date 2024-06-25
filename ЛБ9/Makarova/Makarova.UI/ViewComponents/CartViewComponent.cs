using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Flowers.Domain.Models;
using Yeroma.UI.Extensions;

namespace Yeroma.UI.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cart = HttpContext.Session.Get<Cart>("cart");
            return View(cart);
        }
    }
}