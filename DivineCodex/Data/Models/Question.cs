namespace DivineCodex.Data.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UserId { get; set; }  // Foreign Key to ApplicationUser
        public ApplicationUser User { get; set; }
    }

}
