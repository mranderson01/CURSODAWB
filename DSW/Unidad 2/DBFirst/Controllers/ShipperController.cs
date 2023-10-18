using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DBFirst.Data;
using DBFirst.Models;

namespace DBFirst.Controllers
{
    public class ShipperController : Controller
    {
        private readonly NorthwindContext _context;

        public ShipperController(NorthwindContext context)
        {
            _context = context;
        }

        // GET: Shipper
        public async Task<IActionResult> Index()
        {
              return _context.Shipper != null ? 
                          View(await _context.Shipper.ToListAsync()) :
                          Problem("Entity set 'NorthwindContext.Shipper'  is null.");
        }

        // GET: Shipper/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Shipper == null)
            {
                return NotFound();
            }

            var shipper = await _context.Shipper
                .FirstOrDefaultAsync(m => m.ShipperID == id);
            if (shipper == null)
            {
                return NotFound();
            }

            return View(shipper);
        }

        // GET: Shipper/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Shipper/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShipperID,CompanyName,Phone")] Shipper shipper)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shipper);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shipper);
        }

        // GET: Shipper/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Shipper == null)
            {
                return NotFound();
            }

            var shipper = await _context.Shipper.FindAsync(id);
            if (shipper == null)
            {
                return NotFound();
            }
            return View(shipper);
        }

        // POST: Shipper/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ShipperID,CompanyName,Phone")] Shipper shipper)
        {
            if (id != shipper.ShipperID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shipper);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShipperExists(shipper.ShipperID))
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
            return View(shipper);
        }

        // GET: Shipper/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Shipper == null)
            {
                return NotFound();
            }

            var shipper = await _context.Shipper
                .FirstOrDefaultAsync(m => m.ShipperID == id);
            if (shipper == null)
            {
                return NotFound();
            }

            return View(shipper);
        }

        // POST: Shipper/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Shipper == null)
            {
                return Problem("Entity set 'NorthwindContext.Shipper'  is null.");
            }
            var shipper = await _context.Shipper.FindAsync(id);
            if (shipper != null)
            {
                _context.Shipper.Remove(shipper);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShipperExists(int id)
        {
          return (_context.Shipper?.Any(e => e.ShipperID == id)).GetValueOrDefault();
        }
    }
}
