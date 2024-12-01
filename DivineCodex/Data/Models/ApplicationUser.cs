using Microsoft.AspNetCore.Identity;
using static MudBlazor.CategoryTypes;

namespace DivineCodex.Data.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public int Reputation { get; set; }  // User's reputation points
        public ICollection<Badge> Badges { get; set; }

    }

}
