using Microsoft.AspNetCore.Mvc;
using Yeroma.UI.Services;
using Yeroma.UI.Services.CategoryService;
using Yeroma.UI.Services.FlowersService;

namespace Yeroma.UI.Controllers
{
    public class ProductController(ICategoryService categoryService, IFlowersService flowersService) : Controller
    {
        //public async Task<IActionResult> Index()
        //{
        //    var flowersResponse = await flowersService.GetFlowersListAsync(null);
        //    if (!flowersResponse.Success)
        //        return NotFound(flowersResponse.ErrorMessage);
        //    return View(flowersResponse.Data.Items);
        //}
        public async Task<IActionResult> Index(string? category)
        {
            // получить список категорий
            var categoriesResponse = await
            categoryService.GetCategoryListAsync();
            // если список не получен, вернуть код 404
            if (!categoriesResponse.Success)
                return NotFound(categoriesResponse.ErrorMessage);
            // передать список категорий во ViewData
            ViewData["categories"] = categoriesResponse.Data;
            // передать во ViewData имя текущей категории
            var currentCategory = category == null ? "Все" : categoriesResponse.Data.FirstOrDefault(c => c.NormalizedName == category)?.Name;
            ViewData["currentCategory"] = currentCategory;
            var productResponse = await flowersService.GetFlowersListAsync(category);
            if (!productResponse.Success)
                ViewData["Error"] = productResponse.ErrorMessage;
            return View(productResponse.Data.Items);
        }
    }
}
