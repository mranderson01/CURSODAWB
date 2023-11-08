using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using seguridad5.Data;
using seguridad5.Models;

namespace seguridad5.Controllers
{
    public class EspengController : Controller
    {
        private readonly DiccionarioContext _context;

        public EspengController(DiccionarioContext context)
        {
            _context = context;
        }

        // GET: Espeng
        public async Task<IActionResult> Index()
        {
              return _context.Espengs != null 
                ?View(await _context.Espengs.Take(30).OrderByDescending(order => order.id).ToListAsync()) 
                :Problem("Entity set 'DiccionarioContext.Espengs'  is null.");
        }

        // GET: Espeng/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Espengs == null)
            {
                return NotFound();
            }

            var espeng = await _context.Espengs.FirstOrDefaultAsync(m => m.id == id);
            if (espeng == null)
            {
                return NotFound();
            }

            return View(espeng);
        }

        // GET: Espeng/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Espeng/Create  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,esp,ing")] Espeng espeng)
        {
            if (ModelState.IsValid)
            {
                _context.Add(espeng);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(espeng);
        }

        // GET: Espeng/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Espengs == null)
            {
                return NotFound();
            }

            var espeng = await _context.Espengs.FindAsync(id);
            if (espeng == null)
            {
                return NotFound();
            }
            return View(espeng);
        }

        // POST: Espeng/Edit/5 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,esp,ing")] Espeng espeng)
        {
            if (id != espeng.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(espeng);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EspengExists(espeng.id))
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
            return View(espeng);
        }

        // GET: Espeng/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Espengs == null)
            {
                return NotFound();
            }

            var espeng = await _context.Espengs
                .FirstOrDefaultAsync(m => m.id == id);
            if (espeng == null)
            {
                return NotFound();
            }

            return View(espeng);
        }

        // POST: Espeng/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Espengs == null)
            {
                return Problem("Entity set 'DiccionarioContext.Espengs'  is null.");
            }
            var espeng = await _context.Espengs.FindAsync(id);
            if (espeng != null)
            {
                _context.Espengs.Remove(espeng);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EspengExists(int id)
        {
          return (_context.Espengs?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
