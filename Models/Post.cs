using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace femblogAPI.Models
{
    //[JsonConverter(typeof(StringEnumConverter))]
    public enum PostCategory 
    {
        //[EnumMember(Value= "Post")]
        Post,
        //[EnumMember(Value= "Photography")]
        Photography,
        //[EnumMember(Value= "Video")]
        Video
    }

    public class Post
    {
        public Post()
        {
    
        }

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
        public virtual User PostedBy {get; set;}
       
    }
}

