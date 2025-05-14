using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AgriEnergyConnectApp.Models;

namespace AgriEnergyConnectApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       public DbSet<Employee> Employees { get; set; }
       public DbSet<Farmer> Farmers { get; set; }
       public DbSet<Product> Products { get; set; }

        public DbSet<UserAccount> UserAccounts {  get; set; }

    }
}
