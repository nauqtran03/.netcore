using buoi16_netcore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace buoi16_netcore.Controllers
{
    public class ProductsController : Controller
    {
        private List<Products> products = new List<Products>();        // GET: ProdcutsController
        public ActionResult Index()
        {
            return View(products);
        }

        // GET: ProdcutsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProdcutsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProdcutsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdcutsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProdcutsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdcutsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProdcutsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
