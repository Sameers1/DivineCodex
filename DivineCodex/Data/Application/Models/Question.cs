﻿using DivineCodex.Data.Identity.Models;

namespace DivineCodex.Data.Application.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UserId { get; set; } 
    }
}
