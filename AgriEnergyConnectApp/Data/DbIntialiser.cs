using AgriEnergyConnectApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AgriEnergyConnectApp.Data
{
    public static class DbInitializer
    {
        public static void Seed(ApplicationDbContext context)
        {
            // Ensure database is created
           context.Database.Migrate();

            // Seed UserAccounts
            if (!context.UserAccounts.Any())
            {
                context.UserAccounts.AddRange(
                    new UserAccount { Role = "Employee", Email = "employee1@agrienergy.com", Password = "emp123" },
                    new UserAccount { Role = "Farmer", Email = "ranaa.farmer@agrienergy.com", Password = "farm123" }
                );
                context.SaveChanges();
            }

            // Seed Employees
            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee { FullName = "Qiran Adams", Email = "qiran@agrienergy.com", Password = "password123" },
                    new Employee { FullName = "Aman Adams", Email = "aman@agrienergy.com", Password = "password456" }
                );
                context.SaveChanges();
            }

            // Seed Farmers
            if (!context.Farmers.Any())
            {
                context.Farmers.AddRange(
                    new Farmer { FarmerName = "Ranaa Jacobs", Email = "ranaa.farmer@gmail.com", Location = "Limpopo" },
                    new Farmer { FarmerName = "Jane Doe", Email = "jane.farmer@gmail.com", Location = "Eastern Cape" }
                );
                context.SaveChanges();
            }

            // Seed Products
            if (!context.Products.Any())
            {
                var farmer1 = context.Farmers.FirstOrDefault();
                var farmer2 = context.Farmers.Skip(1).FirstOrDefault();

                if (farmer1 != null && farmer2 != null)
                {
                    context.Products.AddRange(
                        new Product { ProductName = "Watermelon", Category = "Fruit", ProductionDate = new DateTime(2024, 6, 1), FarmerId = farmer1.farmerId },
                        new Product { ProductName = "Carrots", Category = "Vegetables", ProductionDate = new DateTime(2024, 6, 5), FarmerId = farmer2.farmerId },
                        new Product { ProductName = "Pearl Barley", Category = "Grains", ProductionDate = new DateTime(2024, 5, 15), FarmerId = farmer1.farmerId }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}

