using AutoMapper;
using femblogAPI.DTOs;
using femblogAPI.Models;

namespace femblogAPI.Profiles
{
    public class PostsProfile : Profile 
    {
        public PostsProfile()
        {
            //source-> target
            CreateMap<Post, PostReadDTO>();
            CreateMap<PostCreateDTO,Post>();
        }
    }
}