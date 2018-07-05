using Dal.Entities;

namespace Dal.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> Users { get; }

        void SaveChanges();
    }
}