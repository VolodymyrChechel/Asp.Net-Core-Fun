using Bll.Dto.User;

namespace Bll.Interfaces
{
    public interface IUserService
    {
        UserEntityDto Get(int id);
        void Create(UserCreateDto userCreateDto);
    }
}