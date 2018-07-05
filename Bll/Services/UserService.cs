using AutoMapper;
using Bll.Dto.User;
using Bll.Interfaces;
using Dal.Interfaces;

namespace Bll.Services
{
    public class UserService : BaseService, IUserService
    {
        public UserService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        public UserEntityDto Get(int id)
        {
            var user = UnitOfWork.Users.GetOne(id);

        }

        public void Create(UserCreateDto userCreateDto)
        {
            throw new System.NotImplementedException();
        }
    }
}