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
    public class CustomersController : Controller
    {
		private readonly UserManager<ApplicationUser> _userManager;

		private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
			_userManager = userManager;
        }
		private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

		// GET: Customers
		public async Task<IActionResult> Index()
        {
			ApplicationUser loggedInUser = await GetCurrentUserAsync();
			List<Customer> customers = await _context.Customers.Include(c => c.Kayak).Where(c => c.User == loggedInUser).ToListAsync();

			return View(customers);
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.Kayak)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
			CreateCustomerViewModel vm = new CreateCustomerViewModel();
			vm.Kayaks = _context.Kayaks.Select(c => new SelectListItem
			{
				Value = c.Id.ToString(),
				Text = c.Name
			}).ToList();

			vm.Kayaks.Insert(0, new SelectListItem()
			{
				Value = "0",
				Text = "Please Choose A Kayak"
			});
			return View(vm);
		}

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

		//[Bind("Id,UserId,KayakId,Name,PhoneNumber,Email,RentalDate,ReturnDate")]
		//Customer customer

		public async Task<IActionResult> Create(CreateCustomerViewModel vm)
        {
			if (ModelState.IsValid)
			{
				var currentUser = await GetCurrentUserAsync();
				vm.Customer.UserId = currentUser.Id;
				_context.Add(vm.Customer);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			vm.Kayaks = _context.Kayaks.Select(c => new SelectListItem
			{
				Value = c.Id.ToString(),
				Text = c.Name
			}).ToList();

			return View(vm);
		}

		// GET: Customers/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			CreateCustomerViewModel vm = new CreateCustomerViewModel();
			vm.Kayaks = _context.Kayaks.Select(c => new SelectListItem
			{
				Value = c.Id.ToString(),
				Text = c.Name
			}).ToList();

			if (id == null)
			{
				return NotFound();
			}

			vm.Customer = await _context.Customers.FindAsync(id);

			return View(vm);
		}

		// POST: Customers/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,KayakId,Name,PhoneNumber,Email,RentalDate,ReturnDate")] Customer customer)

		{
			if (id != customer.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					var currentUser = await GetCurrentUserAsync();
					customer.UserId = currentUser.Id;
					_context.Update(customer);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!CustomerExists(customer.Id))
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
			ViewData["KayakId"] = new SelectList(_context.KayakTypes, "Id", "Id", customer.KayakId);
			return View(customer);
		}

		// GET: Customers/Delete/5
		public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.Kayak)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
