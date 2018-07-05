using AutoMapper;
using Bll.Dto.User;
using Bll.Interfaces;
using Dal.Entities;
using Dal.Interfaces;

namespace Bll.Services
{
    public class UserService : BaseService, IUserService
    {
        public UserService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        public UserEntityDto Get(int id)
        {
            var user = UnitOfWork.Users.GetOne(id);

            var userDto = Mapper.Map<User, UserEntityDto>(user);

            return userDto;
        }

        public void Create(UserCreateDto userCreateDto)
        {
            var user = Mapper.Map<UserCreateDto, User>(userCreateDto);

            UnitOfWork.Users.Add(user);
            UnitOfWork.SaveChanges();
        }
    }
}