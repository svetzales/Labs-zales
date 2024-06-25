using Microsoft.AspNetCore.Mvc;

namespace Yeroma.UI.Views.Shared.Components.Cart
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
