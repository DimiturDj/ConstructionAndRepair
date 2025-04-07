using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepairAndConstruction.Models;

namespace RepairAndConstruction.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var model = new AdminDashboardViewModel
            {
                TotalUsers = await _context.Customers.CountAsync(),
                TotalWorkers = await _context.Workers.CountAsync(),
                TotalJobOffers = await _context.JobOffers.CountAsync(),
                TotalBookings = await _context.Bookings.CountAsync(),
                TotalReviews = await _context.Reviews.CountAsync()
            };

            return View(model);
        }
    }
}
