using btvn_bai2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace btvn_bai2.Controllers
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
            var categories = new List<Category>
    {
        new Category(1, "Quần Áo"),
        new Category(2, "Túi Xách"),
        new Category(3, "Đồng Hồ"),
        new Category(4, "Ti Vi"),
        new Category(5, "Tủ Lạnh"),
        new Category(6, "Máy Bơm"),
        new Category(7, "Quạt Điện"),
        new Category(8, "Lò Sưởi"),
    };

            ViewData["Categories"] = categories;

            var products = new List<Product>
    {
        new Product(1, "Bộ đồ Nam", 100000, "Phù hợp cho Nam", 1, new DateTime(2024, 09, 19)),
        new Product(2, "Bộ đồ Nữ", 100000, "Phù hợp cho Nữ", 0, new DateTime(2024, 09, 12)),
    };

            ViewData["Products"] = products;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //public PartialViewResult GetCategory()
        //{
        //    List<Category> categories = new List<Category>()
        //    {
        //        new Category(1, "Quần Áo"),
        //        new Category(2, "Túi Xách"),
        //        new Category(3, "Đồng Hồ"),
        //        new Category(4, "Ti Vi"),
        //        new Category(5, "Tủ Lạnh"),
        //        new Category(6, "Máy Bơm"),
        //        new Category(7, "Quạt Điện"),
        //        new Category(8, "Lò Sưởi"),
        //    };
        //    return PartialView("_CategoryPartialView", categories);
        //}
        //public PartialViewResult GetProduct()
        //{
        //    List<Product> products = new List<Product>()
        //    {
        //        new Product(1,"Bộ đồ Nam", 100000,"Phù hợp cho Nam",1, new DateTime(2024, 09, 19)),
        //        new Product(1,"Bộ đồ Nữ", 100000,"Phù hợp cho Nữ",0, new DateTime(2024, 09, 12)),

        //    };
        //    return PartialView("_ProductPartialView", products);
        //}
    }
}
