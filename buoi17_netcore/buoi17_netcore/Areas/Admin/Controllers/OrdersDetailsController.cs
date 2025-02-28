﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using buoi17_netcore.Models.DBModel;

namespace buoi17_netcore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrdersDetailsController : Controller
    {
        private readonly DatabaseFirstContext _context;

        public OrdersDetailsController(DatabaseFirstContext context)
        {
            _context = context;
        }

        // GET: Admin/OrdersDetails
        public async Task<IActionResult> Index()
        {
            var databaseFirstContext = _context.OrdersDetails.Include(o => o.Orders).Include(o => o.Product);
            return View(await databaseFirstContext.ToListAsync());
        }

        // GET: Admin/OrdersDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordersDetail = await _context.OrdersDetails
                .Include(o => o.Orders)
                .Include(o => o.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ordersDetail == null)
            {
                return NotFound();
            }

            return View(ordersDetail);
        }

        // GET: Admin/OrdersDetails/Create
        public IActionResult Create()
        {
            ViewData["OrdersId"] = new SelectList(_context.Orders, "Id", "Id");
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id");
            return View();
        }

        // POST: Admin/OrdersDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OrdersId,ProductId,Price,Quantity,TotalPrice")] OrdersDetail ordersDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ordersDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrdersId"] = new SelectList(_context.Orders, "Id", "Id", ordersDetail.OrdersId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", ordersDetail.ProductId);
            return View(ordersDetail);
        }

        // GET: Admin/OrdersDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordersDetail = await _context.OrdersDetails.FindAsync(id);
            if (ordersDetail == null)
            {
                return NotFound();
            }
            ViewData["OrdersId"] = new SelectList(_context.Orders, "Id", "Id", ordersDetail.OrdersId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", ordersDetail.ProductId);
            return View(ordersDetail);
        }

        // POST: Admin/OrdersDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OrdersId,ProductId,Price,Quantity,TotalPrice")] OrdersDetail ordersDetail)
        {
            if (id != ordersDetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordersDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdersDetailExists(ordersDetail.Id))
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
            ViewData["OrdersId"] = new SelectList(_context.Orders, "Id", "Id", ordersDetail.OrdersId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", ordersDetail.ProductId);
            return View(ordersDetail);
        }

        // GET: Admin/OrdersDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordersDetail = await _context.OrdersDetails
                .Include(o => o.Orders)
                .Include(o => o.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ordersDetail == null)
            {
                return NotFound();
            }

            return View(ordersDetail);
        }

        // POST: Admin/OrdersDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ordersDetail = await _context.OrdersDetails.FindAsync(id);
            if (ordersDetail != null)
            {
                _context.OrdersDetails.Remove(ordersDetail);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdersDetailExists(int id)
        {
            return _context.OrdersDetails.Any(e => e.Id == id);
        }
    }
}
