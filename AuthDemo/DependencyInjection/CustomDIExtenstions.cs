using AuthDemo.Infrastructure;
using AutoMapper;
using Bll.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace AuthDemo.DependencyInjection
{
    public static class CustomDiExtenstions
    {
        public static void AddMapper(this IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MapperWebProfile>();
                cfg.AddProfile<MapperBllProfile>();
            });


            var mapper = config.CreateMapper();

            services.AddSingleton<IMapper>(mapper);
        }
    }
}