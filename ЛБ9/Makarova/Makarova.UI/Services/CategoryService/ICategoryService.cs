using Flowers.Domain.Entities;
using Flowers.Domain.Models;

namespace Yeroma.UI.Services.CategoryService
{
    public interface ICategoryService
    {
        public Task<ResponseData<List<Category>>> GetCategoryListAsync();
    }
}
