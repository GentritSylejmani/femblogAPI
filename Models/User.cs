using System.ComponentModel.DataAnnotations;
using  System.Collections.Generic;

namespace femblogAPI.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }   
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string password { get; set;}
        public  ICollection<Post> Posts {get; set;}
    }
}