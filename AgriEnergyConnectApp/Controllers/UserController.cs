using Microsoft.AspNetCore.Mvc;
using AgriEnergyConnectApp.Data;
using AgriEnergyConnectApp.Models;

namespace AgriEnergyConnectApp.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
      

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(); // Make sure Views/User/Login.cshtml exists
        }

        [HttpPost]
        public IActionResult Login(UserAccount user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = _context.UserAccounts
                    .FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);

                if (existingUser != null)
                {
                    HttpContext.Session.SetString("UserRole", existingUser.Role);
                    HttpContext.Session.SetString("UserEmail", existingUser.Email); // Optional

                    if (existingUser.Role == "Employee")
                        return RedirectToAction("AddFarmer", "Employee");
                    else if (existingUser.Role == "Farmer")
                        return RedirectToAction("AddProduct", "Farmer");

                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid credentials");
            }

            return View(user);
        }
        public bool IsAuthorized(string requiredRole)
        {
            var userRole = HttpContext.Session.GetString("UserRole");
            return userRole == requiredRole;
        }
    }
}
