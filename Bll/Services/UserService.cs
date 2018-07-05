using Bll.Dto.User;
using Bll.Interfaces;
using Dal.Interfaces;

namespace Bll.Services
{
    public class UserService : BaseService, IUserService
    {
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public UserEntityDto Get(int id)
        {
            UnitOfWork.Users().
        }

        public void Create(UserCreateDto userCreateDto)
        {
            throw new System.NotImplementedException();
        }
    }
}