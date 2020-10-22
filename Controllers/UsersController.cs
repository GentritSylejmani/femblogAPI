using System.Collections.Generic;
using AutoMapper;
using femblogAPI.Data;
using femblogAPI.DTOs;
using femblogAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace femblogAPI.Controllers
{
    //api/users
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IFemblogRepo _repository;

        public UsersController(IFemblogRepo repository, IMapper mapper)
     {
         _mapper = mapper;
         _repository = repository;
     }
        
        [HttpGet]
        public ActionResult<IEnumerable<UserReadDTO>> GetAllUsers()
        {

            var users = _mapper.Map<IEnumerable<UserReadDTO>>(_repository.GetAllUsers());

            if(users!=null)
            {
                return Ok(users);
            }

            return NotFound();
        }

        [HttpGet("{id}",Name="GetUserById")]
        public ActionResult<UserReadDTO> GetUserById(int id)
        {
            var user =_mapper.Map<UserReadDTO>(_repository.GetUserById(id));

            if(user!=null)
            {
                return Ok(user);
            }
            
            return NotFound();
        }

        //POST api/users
        [HttpPost]
        public ActionResult<UserReadDTO> CreateUser(UserCreateDTO createUser)
        {
            var user = _mapper.Map<User>(createUser);

            _repository.CreateUser(user);
            _repository.SaveChanges();

            var userread = _repository.GetUserById(user.UserId);

            return CreatedAtRoute(nameof(GetUserById), new {id = userread.UserId},userread);
        }

    }
}