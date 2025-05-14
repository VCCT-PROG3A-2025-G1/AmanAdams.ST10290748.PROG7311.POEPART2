using Microsoft.AspNetCore.Mvc;

namespace AgriEnergyConnectApp.Models
{
    public class ProductFilter 
    {
        public string SearchTerm { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
