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
            var mappedposts=_mapper.Map<IEnumerable<PostReadDTO>>(postItems);

            foreach(var post in mappedposts)
            {
                foreach(var user in _repository.GetAllUsers())
                {
                    if(post.UserId==user.UserId)
                    {
                        post.PostedBy.UserId = user.UserId;
                        post.PostedBy.Name = user.Name;
                        post.PostedBy.Surname = user.Surname;
                    }
                }
            }

            
            if(postItems!= null)
            {             
                return Ok(mappedposts);
            }

            return NotFound();
            
        }

        //GET api/posts/{id}
        [HttpGet("{id}",Name="GetPostById")]
        public ActionResult<PostReadDTO> GetPostById(int id)
        {
            var postItem = _repository.GetPostById(id);
            var post =_mapper.Map<PostReadDTO>(postItem);

             foreach(var user in _repository.GetAllUsers())
                {
                    if(post.UserId==user.UserId)
                    {
                        post.PostedBy.UserId = user.UserId;
                        post.PostedBy.Name = user.Name;
                        post.PostedBy.Surname = user.Surname;
                        post.Posttime = DateTime.Now;
                    }
                }
            
            if(postItem!= null)
            {
                return Ok(post);
            }
            return NotFound();
        }

        //POST api/posts
        [HttpPost]
        public ActionResult <PostReadDTO> CreatePost(PostCreateDTO createPost)
        {
            
            var postmodel = _mapper.Map<Post>(createPost);

            _repository.CreatePost(postmodel);
            _repository.SaveChanges();

            var postread = _mapper.Map<PostReadDTO>(postmodel);

            postread.PostedBy = _mapper.Map<UserReadDTO>(_repository.GetUserById(postread.UserId));

            return CreatedAtRoute(nameof(GetPostById),new {id = postread.PostID},postread);
        }
    }
}