using btvn_bai1.Models;
using Microsoft.AspNetCore.Mvc;

namespace btvn_bai1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>()
            {
                new Account(1,"Quan1","Quan1@gmail.com","0376219421", Url.Content("~/Avatar/01.png"), "Thanh Hoa","My name is Quan1",1,new DateTime(2003,11,16)),
                new Account(2,"Quan2","Quan2@gmail.com","0376219422", Url.Content("~/Avatar/02.png"), "Ha Noi","My name is Quan2",1,new DateTime(2003,12,17)),
                new Account(3,"Quan3","Quan3@gmail.com","0376219423", Url.Content("~/Avatar/03.png"), "Sai Gon","My name is Quan3",1,new DateTime(2003,10,18)),
                new Account(4,"Quan4","Quan4@gmail.com","0376219424", Url.Content("~/Avatar/04.png"), "Da Nang","My name is Quan4",1,new DateTime(2003,09,19)),
            };
            ViewBag.Accounts = accounts;
            return View();

        }
        //[Route("Ho-so-cua-toi", Name = "profile")]
        public IActionResult Profile(int id)
        {
            List<Account> accounts = new List<Account>
            {
                new Account(1, "Quan1", "Quan1@gmail.com", "0376219421", Url.Content("~/Avatar/01.png"), "Thanh Hoa", "My name is Quan1", 0, new DateTime(2003, 11, 16)),
                new Account(2, "Quan2", "Quan2@gmail.com", "0376219422", Url.Content("~/Avatar/02.png"), "Ha Noi", "My name is Quan2", 0, new DateTime(2003, 12, 17)),
                new Account(3, "Quan3", "Quan3@gmail.com", "0376219423", Url.Content("~/Avatar/03.png"), "Sai Gon", "My name is Quan3", 1, new DateTime(2003, 10, 18)),
                new Account(4, "Quan4", "Quan4@gmail.com", "0376219424", Url.Content("~/Avatar/04.png"), "Da Nang", "My name is Quan4", 1, new DateTime(2003, 09, 19)),
            };
            Account account = accounts.FirstOrDefault(a => a.Id == id); 
            //ViewBag.account = account;
            return View(account);
        }
    }
}
