using System.Collections.Generic;
using femblogAPI.Data;
using femblogAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace femblogAPI.Controllers
{
    //api/users
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IFemblogRepo _repository;

        public UsersController(IFemblogRepo repository)
     {
         _repository = repository;
     }
        
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {

            var users = _repository.GetAllUsers();

            if(users!=null)
            {
                return Ok(users);
            }

            return NotFound();
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            var user = _repository.GetUserById(id);

            if(user!=null)
            {
                return Ok(user);
            }
            
            return NotFound();
        }

    }
}