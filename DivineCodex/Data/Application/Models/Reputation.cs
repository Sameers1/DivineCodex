using DivineCodex.Data.Identity.Models;

namespace DivineCodex.Data.Application.Models
{
    public class Reputation
    {
        public int Id { get; set; }
        public string UserId { get; set; }  // Foreign Key to ApplicationUser
        public int Points { get; set; }  // Total reputation points
    }

}
