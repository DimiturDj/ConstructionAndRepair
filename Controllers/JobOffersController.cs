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
                .Include(j => j.Worker) // Включваме работника за всяка оферта
                .ToListAsync();

            return View(jobOffers);
        }

        // GET: JobOffers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var jobOffer = await _context.JobOffers
                .Include(j => j.Worker) // Включваме работника за офертата
                .FirstOrDefaultAsync(m => m.Id == id);

            if (jobOffer == null) return NotFound();

            return View(jobOffer);
        }

        // GET: JobOffers/Create
        public IActionResult Create()
        {
            ViewData["WorkerId"] = new SelectList(_context.Workers, "Id", "FullName");
            return View();
        }

        // POST: JobOffers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,Price,WorkerId")] JobOffer jobOffer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobOffer); // Добавяме новата оферта в базата
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); // След успешно създаване пренасочваме към Index
            }

            // Ако има грешка при попълване на формата, връщаме на същата форма
            ViewData["WorkerId"] = new SelectList(_context.Workers, "Id", "FullName", jobOffer.WorkerId);
            return View(jobOffer);
        }

        // GET: JobOffers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var jobOffer = await _context.JobOffers.FindAsync(id);
            if (jobOffer == null) return NotFound();

            // Зареждаме работниците за избор в падащото меню
            ViewData["WorkerId"] = new SelectList(_context.Workers, "Id", "FullName", jobOffer.WorkerId);
            return View(jobOffer);
        }

        // POST: JobOffers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,Price,WorkerId")] JobOffer jobOffer)
        {
            if (id != jobOffer.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobOffer); // Обновяваме съществуващата оферта
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobOfferExists(jobOffer.Id)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index)); // След успешно обновяване пренасочваме към Index
            }

            ViewData["WorkerId"] = new SelectList(_context.Workers, "Id", "FullName", jobOffer.WorkerId);
            return View(jobOffer);
        }

        // GET: JobOffers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
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
            _context.JobOffers.Remove(jobOffer); // Премахваме офертата от базата
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index)); // След успешно изтриване пренасочваме към Index
        }

        private bool JobOfferExists(int id)
        {
            return _context.JobOffers.Any(e => e.Id == id); // Проверка дали офертата съществува
        }
    }
}
