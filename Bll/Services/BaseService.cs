using AutoMapper;
using Dal.Interfaces;

namespace Bll.Services
{
    public abstract class BaseService
    {
        protected IUnitOfWork UnitOfWork { get; set; }
        protected IMapper Mapper { get; set; }

        protected BaseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }
    }
}