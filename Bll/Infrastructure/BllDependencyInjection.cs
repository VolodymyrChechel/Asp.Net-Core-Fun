using Dal.Ef;
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


        }
    }
}