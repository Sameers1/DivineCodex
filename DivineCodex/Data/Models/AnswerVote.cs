namespace DivineCodex.Data.Models
{
    public class AnswerVote
    {
        public int Id { get; set; }
        public int AnswerId { get; set; }  // Foreign Key to Answer
        public Answer Answer { get; set; }
        public string UserId { get; set; }  // Foreign Key to ApplicationUser
        public ApplicationUser User { get; set; }
        public bool IsUpvote { get; set; }  // True for upvote, false for downvote
    }

}
