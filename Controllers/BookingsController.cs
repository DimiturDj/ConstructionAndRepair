using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
        public IActionResult Create()
        {
            ViewData["JobOfferId"] = new SelectList(_context.JobOffers.Include(j => j.Worker)
                .ToList()
                .Select(j => new
                {
                    j.Id,
                    Text = $"{j.Title} ({j.Worker.FullName})"
                }), "Id", "Text");

            return View(new Booking
            {
                BookingDate = DateTime.Now,
                Status = "Pending"
            });
        }

        // POST: Bookings/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Booking booking)
        {
            // Търсим клиента по име
            var customer = await _context.Customers
                .FirstOrDefaultAsync(c => c.FullName == booking.Customer.FullName);

            if (customer == null)
            {
                // Създаваме нов клиент, ако не съществува
                customer = new Customer { FullName = booking.Customer.FullName };
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();
            }

            booking.CustomerId = customer.Id;
            booking.Customer = null; // За безопасност

            // Добавяме CustomerId ръчно към ModelState
            ModelState.SetModelValue(nameof(booking.CustomerId), new ValueProviderResult(booking.CustomerId.ToString()));

            if (ModelState.IsValid)
            {
                _context.Bookings.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["JobOfferId"] = new SelectList(_context.JobOffers, "Id", "Title", booking.JobOfferId);
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
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.Id == id);
        }
    }
}
