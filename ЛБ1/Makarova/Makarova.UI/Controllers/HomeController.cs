using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static Yeroma.UI.Controllers.HomeController;

namespace Yeroma.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Text = "Лабораторная работа №1";
            return View();
        }
        public class ListDemo
        {
            public int ListItemValue { get; set; }
        }
    }
}
