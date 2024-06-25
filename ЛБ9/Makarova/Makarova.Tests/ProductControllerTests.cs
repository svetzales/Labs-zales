using Flowers.Domain.Entities;
using Flowers.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yeroma.UI.Controllers;
using Yeroma.UI.Services.CategoryService;
using Yeroma.UI.Services.FlowersService;

namespace Yeroma.Tests
{
    public class ProductControllerTests
    {
        IProductService _flowersService;
        ICategoryService _categoryService;
        public ProductControllerTests()
        {
            SetupData();
        }
        // Список категорий сохраняется во ViewData
        [Fact]
        public async void IndexPutsCategoriesToViewData()
        {
            //arrange
            var controller = new ProductController(_categoryService, _flowersService);
            //act
            var response = await controller.Index(null);
            //assert
            var view = Assert.IsType<ViewResult>(response);
            var categories = Assert.IsType<List<Category>>(view.ViewData["categories"]);
            Assert.Equal(6, categories.Count);
            Assert.Equal("Все", view.ViewData["currentCategory"]);
        }
        // Имя текущей категории сохраняется во ViewData
        [Fact]
        public async void IndexSetsCorrectCurrentCategory()
        {
            //arrange
            var categories = await _categoryService.GetCategoryListAsync();
            var currentCategory = categories.Data[0];
            var controller = new ProductController(_categoryService, _flowersService);
            //act
            var response = await controller.Index(currentCategory.NormalizedName);
            //assert
            var view = Assert.IsType<ViewResult>(response);
            Assert.Equal(currentCategory.Name, view.ViewData["currentCategory"]);
        }
        // В случае ошибки возвращается NotFoundObjectResult
        [Fact]
        public async void IndexReturnsNotFound()
        {
            //arrange
            string errorMessage = "Test error";
            var categoriesResponse = new ResponseData<List<Category>>();
            categoriesResponse.Success = false;
            categoriesResponse.ErrorMessage = errorMessage;
            _categoryService.GetCategoryListAsync().Returns(Task.FromResult(categoriesResponse))
            ;
            var controller = new ProductController(_categoryService, _flowersService);
            //act
            var response = await controller.Index(null);
            //assert
            var result = Assert.IsType<NotFoundObjectResult>(response);
            Assert.Equal(errorMessage, result.Value.ToString());
        }
        // Настройка имитации ICategoryService и IFlowersService
        void SetupData()
        {
            _categoryService = Substitute.For<ICategoryService>();
            var categoriesResponse = new ResponseData<List<Category>>();
            categoriesResponse.Data = new List<Category>
            {
                new Category {Id=1, Name="в упаковке",NormalizedName="packaging"},
                new Category {Id=2, Name="в коробках",NormalizedName="box"},
                new Category {Id=3, Name="в корзинах",NormalizedName="basket"},
            };
            _categoryService.GetCategoryListAsync().Returns(Task.FromResult(categoriesResponse))
            ;
            _flowersService = Substitute.For<IProductService>();
            var flowers = new List<Flower>
            {
                new Flower { Id = 1 },
                new Flower { Id = 2 },
                new Flower { Id = 3 },
            };
            var productResponse = new ResponseData<ProductListModel<Flower>>();
            productResponse.Data = new ProductListModel<Flower> { Items = flowers };
            _flowersService.GetFlowersListAsync(Arg.Any<string?>(), Arg.Any<int>())
            .Returns(productResponse);
        }
    }
}
