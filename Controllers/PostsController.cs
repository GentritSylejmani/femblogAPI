using System.Collections.Generic;
using femblogAPI.Data;
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

        public PostsController(IFemblogRepo repository)
        {
            _repository= repository;
        }

        //private readonly MockFemblogRepo _repository = new MockFemblogRepo();

        //GET api/posts
        [HttpGet]
        public ActionResult<IEnumerable<Post>> GetAllPosts()
        {
            var postItems = _repository.GetAllPosts();

            return Ok(postItems);
        }

        //GET api/posts/{id}
        [HttpGet("{id}")]
        public ActionResult<Post> GetPostById(int id)
        {
            var postItem = _repository.GetPostById(id);

            return Ok(postItem);
        }
    }
}