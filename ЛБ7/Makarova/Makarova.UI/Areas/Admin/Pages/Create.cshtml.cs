using Flowers.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Yeroma.UI.Services.CategoryService;
using Yeroma.UI.Services.FlowersService;

namespace Yeroma.UI.Areas.Admin.Pages
{
    public class CreateModel(ICategoryService categoryService, IFlowersService flowersService) : PageModel
    {
        public async Task<IActionResult>OnGet()
        {
            var categoryListData = await categoryService.GetCategoryListAsync();
            ViewData["CategoryId"] = new SelectList(categoryListData.Data, "Id", "Name");
            return Page();
        }
        [BindProperty]
        public Flower Flower { get; set; } = default!;

        [BindProperty]
        public IFormFile? Image { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult>
            OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await flowersService.CreateFlowersAsync(Flower, Image);
            return RedirectToPage("./Index");
        }
    }

}
