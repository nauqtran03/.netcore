using buoi17_netcore.Models;
using Microsoft.AspNetCore.Mvc;

namespace buoi17_netcore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Login model)
        {
            if (!ModelState.IsValid){
                return View(model);
            }
            HttpContext.Session.SetString("AdminLogin", model.UserName);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
