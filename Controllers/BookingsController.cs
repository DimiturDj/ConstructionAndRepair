using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RepairAndConstruction.Models;

namespace RepairAndConstruction.Controllers
{
    public class BookingsController : Controller
    {
        private readonly AppDbContext _context;

        public BookingsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Bookings
        public async Task<IActionResult> Index()
        {
            var bookings = await _context.Bookings
                .Include(b => b.Customer)
                .Include(b => b.JobOffer)
                .ThenInclude(j => j.Worker)
                .ToListAsync();

            return View(bookings);
        }

        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var booking = await _context.Bookings
                .Include(b => b.Customer)
                .Include(b => b.JobOffer)
                    .ThenInclude(j => j.Worker)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (booking == null) return NotFound();

            return View(booking);
        }

        // GET: Bookings/Create
        public IActionResult Create(int? jobOfferId)
        {
            var username = HttpContext.Session.GetString("Username");
            var role = HttpContext.Session.GetString("Role");

            if (string.IsNullOrEmpty(username) || role != "Customer")
                return RedirectToAction("Login", "Account");

            var offers = _context.JobOffers
                .Include(j => j.Worker)
                .ToList()
                .Select(j => new
                {
                    j.Id,
                    Text = $"{j.Title} ({j.Worker.FullName})"
                });

            ViewData["JobOfferId"] = new SelectList(offers, "Id", "Text", jobOfferId);

            return View(new Booking
            {
                BookingDate = DateTime.Now,
                Status = "Pending",
                JobOfferId = jobOfferId ?? 0
            });
        }

        // POST: Bookings/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Booking booking)
        {
            var username = HttpContext.Session.GetString("Username");
            var role = HttpContext.Session.GetString("Role");

            if (string.IsNullOrEmpty(username) || role != "Customer")
                return RedirectToAction("Login", "Account");

            var customer = await _context.Customers
                .FirstOrDefaultAsync(c => c.FullName == username);

            if (customer == null)
            {
                ModelState.AddModelError("", "Customer not found.");
            }
            else
            {
                booking.CustomerId = customer.Id;
                booking.Customer = null;
                booking.BookingDate = DateTime.Now;
                booking.Status = "Pending";

                if (ModelState.IsValid)
                {
                    _context.Bookings.Add(booking);
                    await _context.SaveChangesAsync();

                    TempData["SuccessMessage"] = "Booking created successfully!";
                    return RedirectToAction("Index", "JobOffers");
                }
            }

            var offers = _context.JobOffers
                .Include(j => j.Worker)
                .ToList()
                .Select(j => new
                {
                    j.Id,
                    Text = $"{j.Title} ({j.Worker.FullName})"
                });

            ViewData["JobOfferId"] = new SelectList(offers, "Id", "Text", booking.JobOfferId);
            return View(booking);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var booking = await _context.Bookings
                .Include(b => b.Customer)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (booking == null) return NotFound();

            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "FullName", booking.CustomerId);
            ViewData["JobOfferId"] = new SelectList(_context.JobOffers, "Id", "Title", booking.JobOfferId);
            return View(booking);
        }

        // POST: Bookings/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CustomerId,JobOfferId,BookingDate,Status")] Booking booking)
        {
            if (id != booking.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.Id)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "FullName", booking.CustomerId);
            ViewData["JobOfferId"] = new SelectList(_context.JobOffers, "Id", "Title", booking.JobOfferId);
            return View(booking);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var booking = await _context.Bookings
                .Include(b => b.Customer)
                .Include(b => b.JobOffer)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (booking == null) return NotFound();

            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.Id == id);
        }
    }
}