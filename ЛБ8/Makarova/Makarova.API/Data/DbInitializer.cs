using Flowers.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Yeroma.API.Data
{
    public static class DbInitializer
    {
        public static async Task SeedData(WebApplication app)
        {
            // Uri проекта
            var uri = "https://localhost:7002/";
            // Получение контекста БД
            using var scope = app.Services.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            // Заполнение данными
            if (!context.Categories.Any() && !context.Flowers.Any())
            {
                var categories = new Category[]
                {
                new Category {Name="в упаковке",NormalizedName="packaging"},
                new Category {Name="в коробках",NormalizedName="box"},
                new Category {Name="в корзинах",NormalizedName="basket"},
                };
                await context.Categories.AddRangeAsync(categories);
                await context.SaveChangesAsync();

                var flower = new List<Flower>
            {
                new Flower
                {
                    Name="Афродита",
                    Description="Красные розы, хлопок",
                    Price =85,
                    Image=uri+"Images/цветы/упаковка/Афродита.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("packaging"))
                },

                new Flower
                {
                    Name="Фемида",
                    Description="Персиковые розы, эвкалипт",
                    Price =68,
                    Image=uri+"Images/цветы/упаковка/Фемида.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("packaging"))
                },

                new Flower
                {
                    Name="Гера",
                    Description="Красные розы, белая хризантема, гипсофиса",
                    Price =55,
                    Image=uri+"Images/цветы/упаковка/Гера.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("packaging"))
                },

                new Flower
                {
                    Name="Афина",
                    Description="Хризантема одиночная белая, эвкалипт",
                    Price =73,
                    Image=uri+"Images/цветы/упаковка/Афина.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("packaging"))
                },

                 new Flower
                {
                    Name="Деметра",
                    Description="Сереневые и персиковые розы, пионовидные розовые розы, сирень, эвкалипт",
                    Price =95,
                    Image=uri+"Images/цветы/упаковка/Деметра.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("packaging"))
                },

                new Flower
                {
                    Name="Геката",
                    Description="Розовые пионы, антирринум, альстромерия, колоски, писташ",
                    Price =70,
                    Image=uri+"Images/цветы/упаковка/Геката.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("packaging"))
                },

                new Flower
                {
                    Name="Артемида",
                    Description="Сереневая и персиковые розы, альстромерия",
                    Price =60,
                    Image=uri+"Images/цветы/упаковка/Артемида.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("packaging"))
                },

                new Flower
                {
                    Name="Персефена",
                    Description="Розовые розы, белая эустома, одиночные белые хризантемы, эвкалипт",
                    Price =95,
                    Image=uri+"Images/цветы/упаковка/Персефена.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("packaging"))
                },

                new Flower
                {
                    Name="Муза",
                    Description="Розовые розы, эвкалипт",
                    Price =50,
                    Image=uri+"Images/цветы/упаковка/Муза.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("packaging"))
                },

                new Flower
                {
                    Name="Немезида",
                    Description="Гортензия, розовая роза, белая эустома, альстромерия,писташ",
                    Price =70,
                    Image=uri+"Images/цветы/коробка/Немезида.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("box"))
                },

                new Flower
                {
                    Name="Дриада",
                    Description="Гортензии, розовые розы, желтые пионовидные розы, розовая эустома",
                    Price =85,
                    Image=uri+"Images/цветы/коробка/Дриада.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("box"))
                },

                new Flower
                {
                    Name="Гея",
                    Description="Розовые кустовые розы",
                    Price =75,
                    Image=uri+"Images/цветы/коробка/Гея.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("box"))
                },

                new Flower
                {
                    Name="Психея",
                    Description="Розовые гортензии, сиреневая роза, розовая и белая эустома",
                    Price =80,
                    Image=uri+"Images/цветы/коробка/Психея.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("box"))
                },

                new Flower
                {
                    Name="Ника",
                    Description="Голубая гортензия, персиковая пионовидная роза, чайная роза, розовая эустома",
                    Price =95,
                    Image=uri+"Images/цветы/коробка/Ника.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("box"))
                },

                new Flower
                {
                    Name="Селена",
                    Description="Розовые и голубые гортензии",
                    Price =60,
                    Image=uri+"Images/цветы/коробка/Селена.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("box"))
                },

                new Flower
                {
                    Name="Гестия",
                    Description="Сиреневая роза, белые фрезии, розовая альстромерия, зеленые хризантемы",
                    Price =125,
                    Image=uri+"Images/цветы/коробка/Гестия.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("box"))
                },

                new Flower
                {
                    Name="Мельпомена",
                    Description="Фиолетовые астры, розовые пионы, ромашка луговая,",
                    Price =115,
                    Image=uri+"Images/цветы/коробка/Мельпомена.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("box"))
                },

                new Flower
                {
                    Name="Юнона",
                    Description="Розовая роза, белая эустома, розовая альстромерия, папоротник",
                    Price =70,
                    Image=uri+"Images/цветы/коробка/Юнона.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("box"))
                },

                new Flower
                {
                    Name="Калипсо",
                    Description="Розовые хризантемы, розовые герберы, фиолетовые эустомы, лаванда",
                    Price =145,
                    Image=uri+"Images/цветы/корзина/Калипсо.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("basket"))
                },

                new Flower
                {
                    Name="Терпсихора",
                    Description="Белые эустомы, белые орхидеи, писташ",
                    Price =160,
                    Image=uri+"Images/цветы/корзина/Терпсихора.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("basket"))
                },

                new Flower
                {
                    Name="Клио",
                    Description="Белые эустомы, розовые кустовые розы, розовые розы, белая гортензия, эвкалипт",
                    Price =195,
                    Image=uri+"Images/цветы/корзина/Клио.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("basket"))
                },

                new Flower
                {
                    Name="Ариадна",
                    Description="Белые розы, лаванда, эвкалипт",
                    Price =170,
                    Image=uri+"Images/цветы/корзина/Ариадна.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("basket"))
                },

                new Flower
                {
                    Name="Эрида",
                    Description="Красные розы, розовые альстромерии, белые хризантемы",
                    Price =185,
                    Image=uri+"Images/цветы/корзина/Эрида.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("basket"))
                },

                new Flower
                {
                    Name="Нюкта",
                    Description="Розовые розы, розовые пионовидные розы, писташ",
                    Price =150,
                    Image=uri+"Images/цветы/корзина/Нюкта.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("basket"))
                },

                new Flower
                {
                    Name="Мнемосина",
                    Description="Розовые пионовидные розы, белые эустомы, белые лютики, белая серень, белый антириумум",
                    Price =215,
                    Image=uri+"Images/цветы/корзина/Мнемосина.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("basket"))
                },

                new Flower
                {
                    Name="Эринии",
                    Description="Синии ирисы, белые хризантемы, писташ",
                    Price =175,
                    Image=uri+"Images/цветы/корзина/Эринии.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("basket"))
                },

                new Flower
                {
                    Name="Гигея",
                    Description="Розовые розы, розовые герберы, белые фрезии, розовые гвоздики",
                    Price =165,
                    Image=uri+"Images/цветы/корзина/Гигея.jpg",
                    Category=categories.FirstOrDefault(c=>c.NormalizedName.Equals("basket"))
                },

            };
                await context.AddRangeAsync(flower);
                await context.SaveChangesAsync();
            }
        }
    }
}
