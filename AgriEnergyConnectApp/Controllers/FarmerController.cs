using AgriEnergyConnectApp.Data;
using AgriEnergyConnectApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AgriEnergyConnectApp.Controllers
{
    public class FarmerController : Controller
    {

        private readonly ApplicationDbContext _context;

        public FarmerController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Farmer()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            if (HttpContext.Session.GetString("UserRole") != "Farmer")
                return RedirectToAction("Login", "User");
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (HttpContext.Session.GetString("UserRole") != "Farmer")
                return RedirectToAction("Login", "User");

            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("AddProduct");
            }

            return View(product);
        }
        public bool IsAuthorized(string requiredRole)
        {
            var userRole = HttpContext.Session.GetString("UserRole");
            return userRole == requiredRole;
        }
    }

}
