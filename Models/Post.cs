using System;

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
        
        public int PostID { get; set; }
        public PostCategory Category { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Posttime { get; set; }
        public User PostedBy {get; set;}
       
    }
}

