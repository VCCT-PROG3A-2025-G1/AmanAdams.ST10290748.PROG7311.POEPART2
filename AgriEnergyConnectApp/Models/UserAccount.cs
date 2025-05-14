using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgriEnergyConnectApp.Models
{
    public class UserAccount 
    {
       
       public int Id { get; set; }
        [Required]
        public string Role {  get; set; }
        [Required]
        public string Email { get; set; }
        [Required]  
        public string Password { get; set; }
    }
}
