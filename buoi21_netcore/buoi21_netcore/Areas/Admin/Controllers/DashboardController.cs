﻿using Microsoft.AspNetCore.Mvc;

namespace buoi21_netcore.Areas.Admin.Controllers
{
    //[Area("Admin")]
    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
