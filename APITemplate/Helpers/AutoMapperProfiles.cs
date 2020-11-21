using AutoMapper;
using ApiTemplate.Dtos;
using ApiTemplate.Models;

namespace ApiTemplate.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UserForRegisterDto, User>();
            CreateMap<User, UserForLoginDto>();
        }
    }
}
