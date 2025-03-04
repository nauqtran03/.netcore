using System.Diagnostics;
using AuthorizeCustom_netcore.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace AuthorizeCustom_netcore.Controllers
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
        public IActionResult Login()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (model.Email != "admin123@gmail.com" || model.Password != "12345")
            {
                ModelState.AddModelError(string.Empty, "Tai khoan khong hop le");
                return View(model);
            }
            var identity = new ClaimsIdentity()
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
