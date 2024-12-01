namespace DivineCodex.Data.Models
{
    public class Reputation
    {
        public int Id { get; set; }
        public string UserId { get; set; }  // Foreign Key to ApplicationUser
        public ApplicationUser User { get; set; }
        public int Points { get; set; }  // Total reputation points
    }

}
