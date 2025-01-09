using System.Diagnostics;
using lesson_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace lesson_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            getProduct();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public PartialViewResult getProduct()
        {
            List<Product> products = new List<Product>() {
                new Product(1,"Tu lanh", "To", 10000),
                new Product(2,"Do gia dung", "Dep", 12000),
                new Product(3,"Mi pham", "To", 15000),
            };
            return PartialView("_ProductsPartialView", products);
        }
    }
}
