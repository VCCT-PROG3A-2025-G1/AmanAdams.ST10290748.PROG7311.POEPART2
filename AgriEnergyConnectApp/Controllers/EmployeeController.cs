using AgriEnergyConnectApp.Data;
using AgriEnergyConnectApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgriEnergyConnectApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Add Farmer
        [HttpGet]
        public IActionResult AddFarmer()
        {

            if (HttpContext.Session.GetString("UserRole") != "Employee")
                return RedirectToAction("Login", "User");

            return View();
        }

        // POST: Add Farmer
        [HttpPost]
        public IActionResult AddFarmer(Farmer farmer)
        {
            if (ModelState.IsValid)
            {
                _context.Farmers.Add(farmer);
                _context.SaveChanges();
                return RedirectToAction("ViewProducts");
            }
            return View(farmer);
        }

        [HttpGet]
        // EmployeeController.cs
        public IActionResult ViewProducts(string? searchTerm, DateTime? startDate, DateTime? endDate)
        {
            if (HttpContext.Session.GetString("UserRole") != "Employee")
                return RedirectToAction("Login", "User");

            var query = _context.Products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query = query.Where(p =>
                    p.ProductName.Contains(searchTerm) ||
                    p.Category.Contains(searchTerm));
                    //p.Farmer.Contains(searchTerm));
            }

            if (startDate.HasValue)
            {
                query = query.Where(p => p.ProductionDate >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                query = query.Where(p => p.ProductionDate <= endDate.Value);
            }

            var viewModel = new ProductFilter
            {
                SearchTerm = searchTerm,
                StartDate = startDate,
                EndDate = endDate,
                Products = query.ToList()
            };

            return View(viewModel);
        }
        public bool IsAuthorized(string requiredRole)
        {
            var userRole = HttpContext.Session.GetString("UserRole");
            return userRole == requiredRole;
        }



    }
}
