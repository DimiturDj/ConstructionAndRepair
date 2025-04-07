using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Register(AppUser user)
        {
            if (ModelState.IsValid)
            {
                if (_context.AppUsers.Any(u => u.Username == user.Username))
                {
                    ModelState.AddModelError("Username", "Username already exists");
                    return View(user);
                }

                _context.AppUsers.Add(user);
                _context.SaveChanges();

                // 🔐 Автоматичен вход след регистрация
                HttpContext.Session.SetString("Username", user.Username);
                HttpContext.Session.SetString("Role", user.Role);

                // Ако новият потребител е Worker
                if (user.Role == "Worker")
                {
                    var worker = _context.Workers.FirstOrDefault(w => w.FullName == user.Username);
                    if (worker != null)
                    {
                        HttpContext.Session.SetInt32("WorkerId", worker.Id);
                    }
                }

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
            var user = _context.AppUsers.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                HttpContext.Session.SetString("Username", user.Username);
                HttpContext.Session.SetString("Role", user.Role);

                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid username or password";
            return View();
        }


        // /Account/Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
