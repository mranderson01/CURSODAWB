﻿using System;
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
    public class MamiferoController : Controller
    {
        private readonly PersistenciaMVCContext _context;

        public MamiferoController(PersistenciaMVCContext context)
        {
            _context = context;
        }

        // GET: Mamifero
        public async Task<IActionResult> Index()
        {
              return _context.Mamifero != null ? 
                          View(await _context.Mamifero.ToListAsync()) :
                          Problem("Entity set 'PersistenciaMVCContext.Mamifero'  is null.");
        }

        // GET: Mamifero/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Mamifero == null)
            {
                return NotFound();
            }

            var mamifero = await _context.Mamifero
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mamifero == null)
            {
                return NotFound();
            }

            return View(mamifero);
        }

        // GET: Mamifero/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mamifero/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMamifero,Id,Name,Description,Age,IdReptil")] Mamifero mamifero)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mamifero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mamifero);
        }

        // GET: Mamifero/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Mamifero == null)
            {
                return NotFound();
            }

            var mamifero = await _context.Mamifero.FindAsync(id);
            if (mamifero == null)
            {
                return NotFound();
            }
            return View(mamifero);
        }

        // POST: Mamifero/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMamifero,Id,Name,Description,Age,IdReptil")] Mamifero mamifero)
        {
            if (id != mamifero.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mamifero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MamiferoExists(mamifero.Id))
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
            return View(mamifero);
        }

        // GET: Mamifero/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Mamifero == null)
            {
                return NotFound();
            }

            var mamifero = await _context.Mamifero
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mamifero == null)
            {
                return NotFound();
            }

            return View(mamifero);
        }

        // POST: Mamifero/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Mamifero == null)
            {
                return Problem("Entity set 'PersistenciaMVCContext.Mamifero'  is null.");
            }
            var mamifero = await _context.Mamifero.FindAsync(id);
            if (mamifero != null)
            {
                _context.Mamifero.Remove(mamifero);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MamiferoExists(int id)
        {
          return (_context.Mamifero?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
