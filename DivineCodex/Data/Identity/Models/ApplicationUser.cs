using Microsoft.AspNetCore.Identity;

namespace DivineCodex.Data.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? ProfileImagePath { get; set; }  
    }

}