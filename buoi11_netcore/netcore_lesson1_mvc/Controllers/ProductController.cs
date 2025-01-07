using Microsoft.AspNetCore.Mvc;
using netcore_lesson1_mvc.Models;

namespace netcore_lesson1_mvc.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product("a","Gao","Rat dep",40000),
            new Product("ab","Tu Lanh","Rat dep",3450000),
            new Product("abc","May Giat","Rat dep",4240000),
        };
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListProduct()
        {
            ViewBag.Products = products;
            return View();
        }
        [Route("demo")]
        public IActionResult DemoProduct()
        {
            ViewData["key1"] = "Du lieu duoc truyen qua view data";
            ViewBag.key2 = "Du lieu duoc truyen qua view bag";
            TempData["key3"] = "Du lieu duoc truyen qua temp data";
            return View();
        }
    }
}
