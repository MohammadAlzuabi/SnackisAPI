﻿namespace SnackisAPI.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid SubCategoryId { get; set; }
    }
}
