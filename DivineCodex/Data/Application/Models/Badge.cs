namespace DivineCodex.Data.Application.Models
{
    public class Badge
    {
        public int Id { get; set; }
        public string Name { get; set; }  // e.g., "Top Contributor", "Expert"
        public string Description { get; set; }
        public string UserId { get; set; }  // Foreign Key to ApplicationUser
        public ApplicationUser User { get; set; }
    }

}
