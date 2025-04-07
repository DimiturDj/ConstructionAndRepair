
﻿using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc;

using RepairAndConstruction.Models;

public class LoginController : Controller
{
    private readonly AppDbContext _context;

    public LoginController(AppDbContext context)
    {
        _context = context;
    }

    // GET: Login
    public IActionResult Index()
    {
        return View();
    }

    // POST: Login
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Login(LoginModel loginModel)
    {
        if (ModelState.IsValid)
        {
            // Find the user from the database
            var user = _context.AppUsers
                .FirstOrDefault(u => u.Username == loginModel.Username && u.Password == loginModel.Password);

            if (user != null && (user.Role == "Admin" || user.Role == "Worker"))
            {
                // Store the session data, including Role
                HttpContext.Session.SetString("Username", loginModel.Username);
                HttpContext.Session.SetString("Role", user.Role);

                // Redirect to respective panel
                if (user.Role == "Admin")
                {
                    return RedirectToAction("Index", "Admin");
                }
                else if (user.Role == "Worker")
                {
                    return RedirectToAction("Index", "Worker");
                }
            }

            // If login fails or user role is invalid
            ViewBag.ErrorMessage = "Invalid credentials or access denied!";
        }

        return View("Index");
    }

    // POST: Logout
    [HttpPost]
    public IActionResult Logout()
    {
        // Clear session data on logout
        HttpContext.Session.Clear();
        return RedirectToAction("Index", "Home");
    }
}
