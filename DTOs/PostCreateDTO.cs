using System;
using femblogAPI.Models;

namespace femblogAPI.DTOs
{

    public class PostCreateDTO
    {
        public PostCategory Category { get; set; }

        public string Title { get; set; }
    
        public string Content { get; set; }
        
        public DateTime Posttime { get; set; }
        public int UserId {get; set;}
    }
}