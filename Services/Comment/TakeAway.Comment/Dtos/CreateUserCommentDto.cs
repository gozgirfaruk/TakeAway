﻿namespace TakeAway.Comment.Dtos
{
    public class CreateUserCommentDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; }
        public string CommentDetail { get; set; }
        public string ProductId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
    }
}
