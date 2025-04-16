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
                .FirstOrDefaultAsync(j => j.Id == id);

            if (jobOffer == null) return NotFound();

            return View(jobOffer);
        }

        // GET: JobOffers/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("Role") == "Customer")
                return RedirectToAction("Index", "Home");

            ViewData["WorkerId"] = new SelectList(_context.Workers, "Id", "FullName");
            return View();
        }

        // POST: JobOffers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,Price,WorkerId")] JobOffer jobOffer)
        {
            if (HttpContext.Session.GetString("Role") == "Customer")
                return RedirectToAction("Index", "Home");

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
            if (HttpContext.Session.GetString("Role") == "Customer")
                return RedirectToAction("Index", "Home");

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
            if (HttpContext.Session.GetString("Role") == "Customer")
                return RedirectToAction("Index", "Home");

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
                    if (!_context.JobOffers.Any(e => e.Id == jobOffer.Id))
                        return NotFound();
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["WorkerId"] = new SelectList(_context.Workers, "Id", "FullName", jobOffer.WorkerId);
            return View(jobOffer);
        }

        // GET: JobOffers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("Role") == "Customer")
                return RedirectToAction("Index", "Home");

            if (id == null) return NotFound();

            var jobOffer = await _context.JobOffers
                .Include(j => j.Worker)
                .FirstOrDefaultAsync(j => j.Id == id);

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
    }
}
