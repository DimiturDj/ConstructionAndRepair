using Microsoft.AspNetCore.Mvc;
using RepairAndConstruction.Models;
using System.Diagnostics;

namespace RepairAndConstruction.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Get the user's role
            var userRole = "Guest"; // Default role if the user is not logged in

            if (User.IsInRole("Admin"))
            {
                userRole = "Admin";
            }
            else if (User.IsInRole("Worker"))
            {
                userRole = "Worker";
            }
            else if (User.IsInRole("Customer"))
            {
                userRole = "Customer";
            }

            // Pass the role to the view
            ViewData["UserRole"] = userRole;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
