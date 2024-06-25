using Flowers.Domain.Entities;
using Flowers.Domain.Models;

namespace Yeroma.UI.Services.CategoryService
{
    public class MemoryCategoryService : ICategoryService
    {
        public Task<ResponseData<List<Category>>>GetCategoryListAsync()
        {
            var categories = new List<Category>
            {
                new Category {Id=1, Name="в упаковке",NormalizedName="packaging"},
                new Category {Id=2, Name="в коробках",NormalizedName="box"},
                new Category {Id=3, Name="в корзинах",NormalizedName="basket"},
            };

            var result = new ResponseData<List<Category>>();
            result.Data = categories;
            return Task.FromResult(result);
        }
    }
}
