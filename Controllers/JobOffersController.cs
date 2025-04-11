using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RepairAndConstruction.Models;

namespace RepairAndConstruction.Controllers
{
    public class JobOffersController : Controller
    {
        private readonly AppDbContext _context;

        public JobOffersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: JobOffers
        public async Task<IActionResult> Index()
        {
            var jobOffers = await _context.JobOffers
                .Include(j => j.Worker)
                .ToListAsync();
            return View(jobOffers);
        }

        // GET: JobOffers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var jobOffer = await _context.JobOffers
                .Include(j => j.Worker)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobOffer == null) return NotFound();

            return View(jobOffer);
        }

        // GET: JobOffers/Create
        public IActionResult Create()
        {
            var role = HttpContext.Session.GetString("Role");
            if (role == "Customer") return RedirectToAction("Index", "Home");

            ViewData["WorkerId"] = new SelectList(_context.Workers, "Id", "FullName");
            return View();
        }

        // POST: JobOffers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,Price,WorkerId")] JobOffer jobOffer)
        {
            var role = HttpContext.Session.GetString("Role");
            if (role == "Customer") return RedirectToAction("Index", "Home");

            if (ModelState.IsValid)
            {
                _context.Add(jobOffer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["WorkerId"] = new SelectList(_context.Workers, "Id", "FullName", jobOffer.WorkerId);
            return View(jobOffer);
        }

        // GET: JobOffers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var role = HttpContext.Session.GetString("Role");
            if (role == "Customer") return RedirectToAction("Index", "Home");

            if (id == null) return NotFound();

            var jobOffer = await _context.JobOffers.FindAsync(id);
            if (jobOffer == null) return NotFound();

            ViewData["WorkerId"] = new SelectList(_context.Workers, "Id", "FullName", jobOffer.WorkerId);
            return View(jobOffer);
        }

        // POST: JobOffers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,Price,WorkerId")] JobOffer jobOffer)
        {
            var role = HttpContext.Session.GetString("Role");
            if (role == "Customer") return RedirectToAction("Index", "Home");

            if (id != jobOffer.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobOffer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobOfferExists(jobOffer.Id)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["WorkerId"] = new SelectList(_context.Workers, "Id", "FullName", jobOffer.WorkerId);
            return View(jobOffer);
        }

        // GET: JobOffers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var role = HttpContext.Session.GetString("Role");
            if (role == "Customer") return RedirectToAction("Index", "Home");

            if (id == null) return NotFound();

            var jobOffer = await _context.JobOffers
                .Include(j => j.Worker)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobOffer == null) return NotFound();

            return View(jobOffer);
        }

        // POST: JobOffers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobOffer = await _context.JobOffers.FindAsync(id);
            if (jobOffer != null)
            {
                _context.JobOffers.Remove(jobOffer);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool JobOfferExists(int id)
        {
            return _context.JobOffers.Any(e => e.Id == id);
        }

        // GET: JobOffers/CreateBooking/5
        public IActionResult CreateBooking(int jobOfferId)
        {
            var username = HttpContext.Session.GetString("Username"); // Проверяваме дали има потребител логнат

            // Ако няма потребител логнат, пренасочваме към страницата за логин
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Login", "Account");
            }

            var jobOffer = _context.JobOffers.FirstOrDefault(j => j.Id == jobOfferId);
            if (jobOffer == null) return NotFound();

            var booking = new Booking
            {
                JobOfferId = jobOfferId,
                BookingDate = DateTime.Now,
                Status = "Pending"
            };

            return View(booking);  // Връщаме изгледа за създаване на резервация
        }

        // POST: JobOffers/CreateBooking
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBooking([Bind("JobOfferId,BookingDate,Status")] Booking booking)
        {
            var username = HttpContext.Session.GetString("Username");
            var customer = _context.Customers.FirstOrDefault(c => c.FullName == username);

            // Ако няма логнат потребител, пренасочваме към логин
            if (customer == null) return RedirectToAction("Login", "Account");

            booking.CustomerId = customer.Id;

            if (ModelState.IsValid)
            {
                _context.Bookings.Add(booking); // Записваме резервацията
                await _context.SaveChangesAsync(); // Записване в базата данни
                return RedirectToAction("Index", "JobOffers"); // Пренасочване към списъка с оферти
            }

            return View(booking); // Връщаме формата при грешка
        }

    }
}
