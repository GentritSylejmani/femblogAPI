using System.ComponentModel.DataAnnotations;

namespace femblogAPI.DTOs
{
    public class UserCreateDTO
    {
        public string username {get; set;}       
        public string Name { get; set; }      
        public string Surname { get; set; }
        public string password{get; set;}

    }
}