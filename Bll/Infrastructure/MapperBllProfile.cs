using AutoMapper;
using Bll.Dto.User;
using Dal.Entities;

namespace Bll.Infrastructure
{
    public class MapperBllProfile : Profile
    {
        public MapperBllProfile()
        {
            CreateMap<UserCreateDto, User>();
            CreateMap<User, UserEntityDto>();
        }
    }
}