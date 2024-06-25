﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static Yeroma.UI.Controllers.HomeController;

namespace Yeroma.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly List<ListDemo> _listData;
        public IActionResult Index()
        {
            ViewData["text"] = "Лабораторная работа №2";
            SelectList data = new SelectList(_listData, "Id", "Name");
            return View(data);
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _listData = new List<ListDemo>
            {
                new ListDemo {Id=1, Name="Item 1"},
                new ListDemo {Id=2, Name="Item 2"},
                new ListDemo {Id=3, Name="Item 3"}
            };
        }

        public class ListDemo
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
