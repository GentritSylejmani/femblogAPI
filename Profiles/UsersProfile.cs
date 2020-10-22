using AutoMapper;
using femblogAPI.DTOs;
using femblogAPI.Models;

namespace femblogAPI.Profiles
{
    public class UsersProfile : Profile 
    {
        public UsersProfile()
        {
            //source-> target
            CreateMap<User, UserReadDTO>();
            CreateMap<UserCreateDTO,User>();
        }
    }
}