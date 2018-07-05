using Dal.Ef;
using Dal.Entities;
using Dal.Interfaces;

namespace Dal.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VictimContext _victimContext;

        public UnitOfWork(VictimContext context)
        {
            _victimContext = context;
        }

        public IGenericRepository<User> Users()
        {
            return new GenericRepository<User>(_victimContext);
        }

        public void SaveChanges()
        {
            _victimContext.SaveChanges();
        }
    }
}