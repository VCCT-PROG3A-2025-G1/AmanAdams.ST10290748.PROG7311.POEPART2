using Microsoft.AspNetCore.Mvc;

namespace AgriEnergyConnectApp.Models
{
    public class Farmer 
    {
        public int farmerId { get; set; }
        public string FarmerName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
