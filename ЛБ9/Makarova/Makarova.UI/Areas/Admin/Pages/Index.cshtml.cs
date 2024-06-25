using Flowers.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Yeroma.UI.Services.FlowersService;

namespace Yeroma.UI.Areas.Admin.Pages
{
    [Authorize(Policy = "admin")]
    public class IndexModel : PageModel
    {
        private readonly IProductService _flowersService;
        public IndexModel(IProductService flowersService)
        {
            //_context = context;
            _flowersService = flowersService;
        }
        public List<Flower> Flower { get; set; } = default!;
        public int CurrentPage { get; set; } = 1;
        public int TotalPages { get; set; } = 1;
        public async Task OnGetAsync(int? pageNo = 1)
        {
            var response = await _flowersService.GetFlowersListAsync(null,pageNo.Value);
            if (response.Success)
            {
                Flower = response.Data.Items;
                CurrentPage = response.Data.CurrentPage;
                TotalPages = response.Data.TotalPages;
            }
        }
    }
}
