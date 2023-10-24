using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PersistenciaMVC.Data;
using PersistenciaMVC.Models;

namespace PersistenciaMVC.Controllers
{
    public class ReptilController : Controller
    {
        private readonly PersistenciaMVCContext _context;

        public ReptilController(PersistenciaMVCContext context)
        {
            _context = context;
        }

        // GET: Reptil
        public async Task<IActionResult> Index()
        {
              return _context.Reptil != null ? 
                          View(await _context.Reptil.ToListAsync()) :
                          Problem("Entity set 'PersistenciaMVCContext.Reptil'  is null.");
        }

        // GET: Reptil/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Reptil == null)
            {
                return NotFound();
            }

            var reptil = await _context.Reptil
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reptil == null)
            {
                return NotFound();
            }

            return View(reptil);
        }

        // GET: Reptil/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reptil/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdReptil,Id,Name,Description,Age,IdMamifero")] Reptil reptil)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reptil);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reptil);
        }

        // GET: Reptil/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Reptil == null)
            {
                return NotFound();
            }

            var reptil = await _context.Reptil.FindAsync(id);
            if (reptil == null)
            {
                return NotFound();
            }
            return View(reptil);
        }

        // POST: Reptil/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdReptil,Id,Name,Description,Age,IdMamifero")] Reptil reptil)
        {
            if (id != reptil.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reptil);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReptilExists(reptil.Id))
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
            return View(reptil);
        }

        // GET: Reptil/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Reptil == null)
            {
                return NotFound();
            }

            var reptil = await _context.Reptil
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reptil == null)
            {
                return NotFound();
            }

            return View(reptil);
        }

        // POST: Reptil/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Reptil == null)
            {
                return Problem("Entity set 'PersistenciaMVCContext.Reptil'  is null.");
            }
            var reptil = await _context.Reptil.FindAsync(id);
            if (reptil != null)
            {
                _context.Reptil.Remove(reptil);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReptilExists(int id)
        {
          return (_context.Reptil?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
