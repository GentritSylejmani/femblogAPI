using System.Collections.Generic;
using AutoMapper;
using femblogAPI.Data;
using femblogAPI.DTOs;
using femblogAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace femblogAPI.Controllers
{

    //api/commands
    [Route("api/posts")]
    [ApiController]
    public class PostsController :ControllerBase
    {
        private readonly IFemblogRepo _repository;
        private readonly IMapper _mapper;

        public PostsController(IFemblogRepo repository,IMapper mapper)
        {
            _repository= repository;
            _mapper= mapper;
        }

        //private readonly MockFemblogRepo _repository = new MockFemblogRepo();

        //GET api/posts
        [HttpGet]
        public ActionResult<IEnumerable<PostReadDTO>> GetAllPosts()
        {
            var postItems = _repository.GetAllPosts();

            if(postItems!= null)
            {
                return Ok(_mapper.Map<IEnumerable<PostReadDTO>>(postItems));
            }

            return NotFound();
            
        }

        //GET api/posts/{id}
        [HttpGet("{id}")]
        public ActionResult<PostReadDTO> GetPostById(int id)
        {
            var postItem = _repository.GetPostById(id);

            
            if(postItem!= null)
            {
                return Ok(_mapper.Map<PostReadDTO>(postItem));
            }

            return NotFound();
        }
    }
}