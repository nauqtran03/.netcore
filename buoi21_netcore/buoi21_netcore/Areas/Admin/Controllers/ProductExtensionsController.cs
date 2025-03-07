using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using buoi21_netcore.Models.DBModel;

namespace buoi21_netcore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductExtensionsController : Controller
    {
        private readonly DevxuongmocContext _context;

        public ProductExtensionsController(DevxuongmocContext context)
        {
            _context = context;
        }

        // GET: Admin/ProductExtensions
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductExtensions.ToListAsync());
        }

        // GET: Admin/ProductExtensions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productExtension = await _context.ProductExtensions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productExtension == null)
            {
                return NotFound();
            }

            return View(productExtension);
        }

        // GET: Admin/ProductExtensions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ProductExtensions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Pid,Eid,Content")] ProductExtension productExtension)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productExtension);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productExtension);
        }

        // GET: Admin/ProductExtensions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productExtension = await _context.ProductExtensions.FindAsync(id);
            if (productExtension == null)
            {
                return NotFound();
            }
            return View(productExtension);
        }

        // POST: Admin/ProductExtensions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Pid,Eid,Content")] ProductExtension productExtension)
        {
            if (id != productExtension.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productExtension);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExtensionExists(productExtension.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(productExtension);
        }

        // GET: Admin/ProductExtensions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productExtension = await _context.ProductExtensions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productExtension == null)
            {
                return NotFound();
            }

            return View(productExtension);
        }

        // POST: Admin/ProductExtensions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productExtension = await _context.ProductExtensions.FindAsync(id);
            if (productExtension != null)
            {
                _context.ProductExtensions.Remove(productExtension);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExtensionExists(int id)
        {
            return _context.ProductExtensions.Any(e => e.Id == id);
        }
    }
}
