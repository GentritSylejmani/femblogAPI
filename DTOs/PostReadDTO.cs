using System;
using femblogAPI.Models;

namespace femblogAPI.DTOs
{
    public class PostReadDTO 
    {
        public PostCategory Category { get; set; }

        public string Title { get; set; }
    
        public string Content { get; set; }
        
        public DateTime Posttime { get; set; }
        public User PostedBy {get; set;}
    }
}