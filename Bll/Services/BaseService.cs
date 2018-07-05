using Dal.Interfaces;

namespace Bll.Services
{
    public abstract class BaseService
    {
        protected IUnitOfWork UnitOfWork { get; set; }

        protected BaseService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
    }
}