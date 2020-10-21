using System.ComponentModel.DataAnnotations;

namespace femblogAPI.DTOs
{
    public class UserReadDTO
    {
        
        public int UserId { get; set; }       
        public string Name { get; set; }      
        public string Surname { get; set; }

    }
}