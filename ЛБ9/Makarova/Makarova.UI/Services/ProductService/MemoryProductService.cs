using Flowers.Domain.Entities;
using Flowers.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Yeroma.UI.Controllers;
using Yeroma.UI.Services.CategoryService;

namespace Yeroma.UI.Services.FlowersService
{
    public class MemoryFlowersService : IProductService
    {
        private readonly IConfiguration _config;
        List<Flower> _flowers;
        List<Category> _categories;
        public MemoryFlowersService([FromServices] IConfiguration config, ICategoryService categoryService)
        {
            _categories = categoryService.GetCategoryListAsync().Result.Data;
            _config = config;
            SetupData();
        }

        /// <summary>
        /// Инициализация списков
        /// </summary>
        private void SetupData()
        {
            _flowers = new List<Flower>
            {
                new Flower 
                {
                    Id = 1,
                    Name="Афродита",
                    Description="Красные розы, хлопок",
                    Price =85, Image="Images/цветы/упаковка/Афродита.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("packaging")).Id
                },

                new Flower 
                {
                    Id = 2,
                    Name="Фемида",
                    Description="Персиковые розы, эвкалипт",
                    Price =68, Image="Images/цветы/упаковка/Фемида.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("packaging")).Id
                },

                new Flower
                {
                    Id = 3,
                    Name="Гера",
                    Description="Красные розы, белая хризантема, гипсофиса",
                    Price =55, Image="Images/цветы/упаковка/Гера.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("packaging")).Id
                },

                new Flower
                {
                    Id = 4,
                    Name="Афина",
                    Description="Хризантема одиночная белая, эвкалипт",
                    Price =73, Image="Images/цветы/упаковка/Афина.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("packaging")).Id
                },

                 new Flower
                {
                    Id = 5,
                    Name="Деметра",
                    Description="Сереневые и персиковые розы, пионовидные розовые розы, сирень, эвкалипт",
                    Price =95, Image="Images/цветы/упаковка/Деметра.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("packaging")).Id
                },

                new Flower
                {
                    Id = 6,
                    Name="Геката",
                    Description="Розовые пионы, антирринум, альстромерия, колоски, писташ",
                    Price =70, Image="Images/цветы/упаковка/Геката.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("packaging")).Id
                },
                
                new Flower
                {
                    Id = 7,
                    Name="Артемида",
                    Description="Сереневая и персиковые розы, альстромерия",
                    Price =60, Image="Images/цветы/упаковка/Артемида.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("packaging")).Id
                },

                new Flower
                {
                    Id = 8,
                    Name="Персефена",
                    Description="Розовые розы, белая эустома, одиночные белые хризантемы, эвкалипт",
                    Price =95, Image="Images/цветы/упаковка/Персефена.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("packaging")).Id
                },

                new Flower
                {
                    Id = 9,
                    Name="Муза",
                    Description="Розовые розы, эвкалипт",
                    Price =50, Image="Images/цветы/упаковка/Муза.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("packaging")).Id
                },

                new Flower
                {
                    Id = 10,
                    Name="Немезида",
                    Description="Гортензия, розовая роза, белая эустома, альстромерия,писташ",
                    Price =70, Image="Images/цветы/коробка/Немезида.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("box")).Id
                },

                new Flower
                {
                    Id = 11,
                    Name="Дриада",
                    Description="Гортензии, розовые розы, желтые пионовидные розы, розовая эустома",
                    Price =85, Image="Images/цветы/коробка/Дриада.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("box")).Id
                },

                new Flower
                {
                    Id = 12,
                    Name="Гея",
                    Description="Розовые кустовые розы",
                    Price =75, Image="Images/цветы/коробка/Гея.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("box")).Id
                },

                new Flower
                {
                    Id = 13,
                    Name="Психея",
                    Description="Розовые гортензии, сиреневая роза, розовая и белая эустома",
                    Price =80, Image="Images/цветы/коробка/Психея.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("box")).Id
                },

                new Flower
                {
                    Id = 14,
                    Name="Ника",
                    Description="Голубая гортензия, персиковая пионовидная роза, чайная роза, розовая эустома",
                    Price =95, Image="Images/цветы/коробка/Ника.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("box")).Id
                },

                new Flower
                {
                    Id = 15,
                    Name="Селена",
                    Description="Розовые и голубые гортензии",
                    Price =60, Image="Images/цветы/коробка/Селена.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("box")).Id
                },

                new Flower
                {
                    Id = 16,
                    Name="Гестия",
                    Description="Сиреневая роза, белые фрезии, розовая альстромерия, зеленые хризантемы",
                    Price =125, Image="Images/цветы/коробка/Гестия.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("box")).Id
                },

                new Flower
                {
                    Id = 17,
                    Name="Мельпомена",
                    Description="Фиолетовые астры, розовые пионы, ромашка луговая,",
                    Price =115, Image="Images/цветы/коробка/Мельпомена.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("box")).Id
                },

                new Flower
                {
                    Id = 18,
                    Name="Юнона",
                    Description="Розовая роза, белая эустома, розовая альстромерия, папоротник",
                    Price =70, Image="Images/цветы/коробка/Юнона.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("box")).Id
                },

                new Flower
                {
                    Id = 19,
                    Name="Калипсо",
                    Description="Розовые хризантемы, розовые герберы, фиолетовые эустомы, лаванда",
                    Price =145, Image="Images/цветы/корзина/Калипсо.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("basket")).Id
                },

                new Flower
                {
                    Id = 20,
                    Name="Терпсихора",
                    Description="Белые эустомы, белые орхидеи, писташ",
                    Price =160, Image="Images/цветы/корзина/Терпсихора.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("basket")).Id
                },

                new Flower
                {
                    Id = 21,
                    Name="Клио",
                    Description="Белые эустомы, розовые кустовые розы, розовые розы, белая гортензия, эвкалипт",
                    Price =195, Image="Images/цветы/корзина/Клио.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("basket")).Id
                },

                new Flower
                {
                    Id = 22,
                    Name="Ариадна",
                    Description="Белые розы, лаванда, эвкалипт",
                    Price =170, Image="Images/цветы/корзина/Ариадна.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("basket")).Id
                },

                new Flower
                {
                    Id = 23,
                    Name="Эрида",
                    Description="Красные розы, розовые альстромерии, белые хризантемы",
                    Price =185, Image="Images/цветы/корзина/Эрида.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("basket")).Id
                },

                new Flower
                {
                    Id = 24,
                    Name="Нюкта",
                    Description="Розовые розы, розовые пионовидные розы, писташ",
                    Price =150, Image="Images/цветы/корзина/Нюкта.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("basket")).Id
                },

                new Flower
                {
                    Id = 25,
                    Name="Мнемосина",
                    Description="Розовые пионовидные розы, белые эустомы, белые лютики, белая серень, белый антириумум",
                    Price =215, Image="Images/цветы/корзина/Мнемосина.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("basket")).Id
                },

                new Flower
                {
                    Id = 26,
                    Name="Эринии",
                    Description="Синии ирисы, белые хризантемы, писташ",
                    Price =175, Image="Images/цветы/корзина/Эринии.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("basket")).Id
                },

                new Flower
                {
                    Id = 27,
                    Name="Гигея",
                    Description="Розовые розы, розовые герберы, белые фрезии, розовые гвоздики",
                    Price =165, Image="Images/цветы/корзина/Гигея.jpg",
                    CategoryId=_categories.Find(c=>c.NormalizedName.Equals("basket")).Id
                },
            };
        }
        public Task<ResponseData<ProductListModel<Flower>>> GetFlowersListAsync(string? categoryNormalizedName, int pageNo = 1)
        {
            // Создать объект результата
            var result = new ResponseData<ProductListModel<Flower>>();
            // Id категории для фильрации
            int? categoryId = null;
            // если требуется фильтрация, то найти Id категории
            // с заданным categoryNormalizedName
            if (categoryNormalizedName != null)
                categoryId = _categories.Find(c =>c.NormalizedName.Equals(categoryNormalizedName))?.Id;
            // Выбрать объекты, отфильтрованные по Id категории,
            // если этот Id имеется
            var data = _flowers.Where(d => categoryId == null || d.CategoryId.Equals(categoryId))?.ToList();

            // получить размер страницы из конфигурации
            int pageSize = _config.GetSection("ItemsPerPage").Get<int>();
            // получить общее количество страниц
            int totalPages = (int)Math.Ceiling(data.Count / (double)pageSize);
            // получить данные страницы
            var listData = new ProductListModel<Flower>()
            {
                Items = data.Skip((pageNo - 1) * pageSize).Take(pageSize).ToList(),
                CurrentPage = pageNo,
                TotalPages = totalPages
            };
            // поместить данные в объект результата
            result.Data = listData;
            // Если список пустой
            if (data.Count == 0)
            {
                result.Success = false;
                result.ErrorMessage = "Нет объектов в выбраннной категории";
            }
            // Вернуть результат
            return Task.FromResult(result);
        }

        public Task<ResponseData<Flower>> GetFlowersByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateFlowersAsync(int id, Flower flowers, IFormFile? formFile)
        {
            throw new NotImplementedException();
        }

        public Task DeleteFlowersAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseData<Flower>> CreateFlowersAsync(Flower flowers, IFormFile? formFile)
        {
            throw new NotImplementedException();
        }
    }
}
