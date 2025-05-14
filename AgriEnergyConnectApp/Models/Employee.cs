using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AgriEnergyConnectApp.Models
{
    public class Employee 
    {
        public int employeeId { get; set; }
        public string FullName { get; set; }
        public string Email {  get; set; }
        public string Password { get; set; }

    }
}
