using System;
using femblogAPI.Data;

namespace femblogAPI.DTOs
{

    public class PostCreateDTO
    {
        public PostCategory Category { get; set; }

        public string Title { get; set; }
    
        public string Content { get; set; }
        
        public DateTime Posttime { get; set; }
        public User PostedBy {get; set;}
    }
}