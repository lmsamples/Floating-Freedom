using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FloatingFreedom.Data;
using FloatingFreedom.Models;

namespace FloatingFreedom.Controllers
{
    public class KayaksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KayaksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Kayaks
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Kayaks.Include(k => k.KayakType).Include(k => k.KayakType).Include(k => k.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Kayaks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kayak = await _context.Kayaks
                .Include(k => k.KayakType)
				.Include(k => k.User)
				.FirstOrDefaultAsync(m => m.Id == id);
            if (kayak == null)
            {
                return NotFound();
            }

            return View(kayak);
        }

        // GET: Kayaks/Create
        public IActionResult Create()
        {
            ViewData["KayakTypeId"] = new SelectList(_context.KayakTypes, "Id", "Id");
			ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
			return View();
        }

        // POST: Kayaks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,KayakTypeId,UserId,Name")] Kayak kayak)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kayak);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KayakTypeId"] = new SelectList(_context.KayakTypes, "Id", "Id", kayak.KayakTypeId);
			ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", kayak.UserId);
			return View(kayak);
        }

        // GET: Kayaks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kayak = await _context.Kayaks.FindAsync(id);
            if (kayak == null)
            {
                return NotFound();
            }
            ViewData["KayakTypeId"] = new SelectList(_context.KayakTypes, "Id", "Id", kayak.KayakTypeId);
			ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", kayak.UserId);
			return View(kayak);
        }

        // POST: Kayaks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,KayakTypeId,UserId,Name")] Kayak kayak)
        {
            if (id != kayak.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kayak);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KayakExists(kayak.Id))
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
            ViewData["KayakTypeId"] = new SelectList(_context.KayakTypes, "Id", "Id", kayak.KayakTypeId);
			ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", kayak.UserId);
			return View(kayak);
        }

        // GET: Kayaks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kayak = await _context.Kayaks
                .Include(k => k.KayakType)
				.Include(k => k.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kayak == null)
            {
                return NotFound();
            }

            return View(kayak);
        }

        // POST: Kayaks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kayak = await _context.Kayaks.FindAsync(id);
            _context.Kayaks.Remove(kayak);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KayakExists(int id)
        {
            return _context.Kayaks.Any(e => e.Id == id);
        }
    }
}
