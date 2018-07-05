using Bll.Interfaces;
using Bll.Services;
using Dal.Ef;
using Dal.Interfaces;
using Dal.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Bll.Infrastructure
{
    public static class BllDependencyInjection
    {
        public static void AddBllServices(this IServiceCollection service, string connection)
        {
            service.AddDbContext<VictimContext>(options =>
            {
                options.UseSqlServer(connection, opt => opt.MigrationsAssembly("AuthDemo"));
            });

            service.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            service.AddScoped<IUnitOfWork, UnitOfWork>();

            service.AddScoped<IUserService, UserService>();
        }
    }
}