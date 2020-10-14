using System;
using System.ComponentModel.DataAnnotations;

namespace femblogAPI.Models
{
    public enum PostCategory 
    {
        Post,
        Photography,
        Video
    }

    public class Post
    {
        [Key]
        public int PostID { get; set; }
        [Required]
        public PostCategory Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime Posttime { get; set; }
        [Required]
        public User PostedBy {get; set;}
       
    }
}

