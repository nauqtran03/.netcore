﻿using buoi21_netcore.Models.DBModel;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;
using System.Linq;

namespace buoi21_netcore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly DatabaseFirstContext _context; 

        public LoginController(DatabaseFirstContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Login model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var passwordHash = GetSha256Hash(model.PassWord);

            var login = _context.Adminusers.FirstOrDefault(u => u.UserName == model.UserName && u.PassWord == passwordHash);

            if (login != null)
            {
                return RedirectToAction("Dashboard", "Home");
            }

            ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng.");
            return View(model);
        }

        private string GetSha256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
