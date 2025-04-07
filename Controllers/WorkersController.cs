using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepairAndConstruction.Models;
using RepairAndConstruction.ViewModels;

namespace RepairAndConstruction.Controllers
{
    public class WorkersController : Controller
    {
        private readonly AppDbContext _context;

        public WorkersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Workers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Workers.ToListAsync());
        }

        // GET: Workers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var worker = await _context.Workers.FirstOrDefaultAsync(m => m.Id == id);
            if (worker == null) return NotFound();

            return View(worker);
        }

        // GET: Workers/Create
        public IActionResult Create()
        {
            var role = HttpContext.Session.GetString("Role");
            if (role == "Worker" || role == "Customer")
                return RedirectToAction("Index", "Home");

            return View();
        }

        // POST: Workers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName,Profession,Location,Rating")] Worker worker)
        {
            var role = HttpContext.Session.GetString("Role");
            if (role == "Worker" || role == "Customer")
                return RedirectToAction("Index", "Home");

            if (ModelState.IsValid)
            {
                _context.Add(worker);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(worker);
        }

        // GET: Workers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var role = HttpContext.Session.GetString("Role");
            if (role == "Worker" || role == "Customer")
                return RedirectToAction("Index", "Home");

            if (id == null) return NotFound();

            var worker = await _context.Workers.FindAsync(id);
            if (worker == null) return NotFound();

            return View(worker);
        }

        // POST: Workers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,Profession,Location,Rating")] Worker worker)
        {
            var role = HttpContext.Session.GetString("Role");
            if (role == "Worker" || role == "Customer")
                return RedirectToAction("Index", "Home");

            if (id != worker.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(worker);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkerExists(worker.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(worker);
        }

        // GET: Workers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var role = HttpContext.Session.GetString("Role");
            if (role == "Worker" || role == "Customer")
                return RedirectToAction("Index", "Home");

            if (id == null) return NotFound();

            var worker = await _context.Workers.FirstOrDefaultAsync(m => m.Id == id);
            if (worker == null) return NotFound();

            return View(worker);
        }

        // POST: Workers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var role = HttpContext.Session.GetString("Role");
            if (role == "Worker" || role == "Customer")
                return RedirectToAction("Index", "Home");

            var worker = await _context.Workers.FindAsync(id);
            _context.Workers.Remove(worker);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkerExists(int id)
        {
            return _context.Workers.Any(e => e.Id == id);
        }

        public async Task<IActionResult> Dashboard()
        {
            var role = HttpContext.Session.GetString("Role");
            var username = HttpContext.Session.GetString("Username");

            if (string.IsNullOrEmpty(username) || role != "Worker")
            {
                return RedirectToAction("Login", "Account");
            }

            var totalJobOffers = await _context.JobOffers.CountAsync();
            var totalBookings = await _context.Bookings.CountAsync();

            var model = new WorkerDashboardViewModel
            {
                TotalJobOffers = totalJobOffers,
                TotalBookings = totalBookings
            };

            return View(model);
        }
    }
}
