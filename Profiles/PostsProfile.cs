using AutoMapper;
using femblogAPI.DTOs;
using femblogAPI.Models;

namespace femblogAPI.Profiles
{
    public class PostsProfile : Profile 
    {
        public PostsProfile()
        {
            CreateMap<Post, PostReadDTO>();
        }
    }
}