using DivineCodex.Data.Identity.Models;

namespace DivineCodex.Data.Application.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsAccepted { get; set; }  // Mark if this answer is accepted
        public int QuestionId { get; set; }  // Foreign Key to Question
        public Question Question { get; set; }
        public string UserId { get; set; }  // Foreign Key to ApplicationUser
        public ApplicationUser User { get; set; }
    }

}
