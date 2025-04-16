using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepairAndConstruction.Models;

namespace RepairAndConstruction.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Account/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        public async Task<IActionResult> Register(AppUser user)
        {
            if (ModelState.IsValid)
            {
                if (_context.AppUsers.Any(u => u.Username == user.Username))
                {
                    ModelState.AddModelError("Username", "Username already exists");
                    return View(user);
                }

                _context.AppUsers.Add(user);
                await _context.SaveChangesAsync();

                if (user.Role == "Customer")
                {
                    var customer = new Customer
                    {
                        FullName = user.Username
                    };
                    _context.Customers.Add(customer);
                }
                else if (user.Role == "Worker")
                {
                    var worker = new Worker
                    {
                        FullName = user.Username,
                        Profession = "Not specified",
                        Location = "Unknown",
                        Rating = 0
                    };
                    _context.Workers.Add(worker);
                }

                await _context.SaveChangesAsync();

                HttpContext.Session.SetString("Username", user.Username);
                HttpContext.Session.SetString("Role", user.Role);

                return RedirectToAction("Index", "Home");
            }

            return View(user);
        }

        // GET: /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = _context.AppUsers
                .FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                HttpContext.Session.SetString("Username", user.Username);
                HttpContext.Session.SetString("Role", user.Role);

                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid username or password";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        // ✅ GET: /Account/ForgotPassword
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        // ✅ POST: /Account/ForgotPassword
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string username, string newPassword)
        {
            var user = await _context.AppUsers.FirstOrDefaultAsync(u => u.Username == username);

            if (user == null)
            {
                ViewBag.Error = "User not found.";
                return View();
            }

            user.Password = newPassword;
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Password changed successfully!";
            return RedirectToAction("Login");
        }
    }
}
