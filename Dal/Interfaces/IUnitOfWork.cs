using Dal.Entities;

namespace Dal.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> Users();

        void SaveAsync();
    }
}