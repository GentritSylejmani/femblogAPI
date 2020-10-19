using System;
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

            //postItem.Category = (PostCategory)Enum.ToObject(typeof(PostCategory) , postItem.Category);
            
            if(postItem!= null)
            {
                return Ok(_mapper.Map<PostReadDTO>(postItem));
            }

            return NotFound();
        }

        //POST api/posts
        [HttpPost]
        public ActionResult <PostReadDTO> CreatePost(PostCreateDTO createPost)
        {
            var postmodel = _mapper.Map<Post>(createPost);
            //createPost.PostedBy = _repository.GetUserById(createPost.PostedBy.UserId); 
            _repository.CreatePost(postmodel);
            _repository.SaveChanges();

            var postread = _mapper.Map<PostReadDTO>(postmodel);

            return CreatedAtRoute(nameof(GetPostById),new {id = postread.PostID},postread);
        }
    }
}