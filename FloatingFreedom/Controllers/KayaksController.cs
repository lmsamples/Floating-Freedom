using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FloatingFreedom.Data;
using FloatingFreedom.Models;
using FloatingFreedom.Models.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace FloatingFreedom.Controllers
{
    public class KayaksController : Controller
    {
		private readonly UserManager<ApplicationUser> _userManager;

		private readonly ApplicationDbContext _context;


        public KayaksController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
			_userManager = userManager;
		}

		private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

		// GET: Kayaks
		public async Task<IActionResult> Index()
        {
			ApplicationUser loggedInUser = await GetCurrentUserAsync();

			List<Kayak> kayaks = await _context.Kayaks.Include(kayaks => kayaks.KayakType).Include(k => k.User).Where(kayaks => kayaks.User == loggedInUser).ToListAsync();
			return View(kayaks);
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
			KayakViewModel kvm = new KayakViewModel();
			kvm.KayakTypes = _context.KayakTypes.Select(kt => new SelectListItem
			{
				Value = kt.Id.ToString(),
				Text = kt.Name
			}).ToList();

			kvm.KayakTypes.Insert(0, new SelectListItem()
			{
				Value = "0",
				Text = "Please Select a Kayak Type"
			});

			return View(kvm);
        }

        // POST: Kayaks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(KayakViewModel kvm)
        {
			if (ModelState.IsValid)
			{
				var currentUser = await GetCurrentUserAsync();
				kvm.Kayak.UserId = currentUser.Id;
				_context.Add(kvm.Kayak);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}

			kvm.KayakTypes = _context.KayakTypes.Select(kt => new SelectListItem 
			{
			Value = kt.Id.ToString(),
			Text = kt.Name
			}).ToList();

			return View(kvm);
        }

		// GET: Kayaks/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			KayakViewModel kvm = new KayakViewModel();
			kvm.KayakTypes = _context.KayakTypes.Select(kt => new SelectListItem
			{
				Value = kt.Id.ToString(),
				Text = kt.Name
			}).ToList();

            if (id == null)
            {
                return NotFound();
            }

            kvm.Kayak = await _context.Kayaks.FindAsync(id);

			return View(kvm);
        }

        // POST: Kayaks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,KayakTypeId,Name")] Kayak kayak)
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
