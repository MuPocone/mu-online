using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MuOnline.Infrastruture.Application.Core;
using MuOnline.Infrastruture.Application.Providers;

namespace MuOnline.EF.DI
{
    public static class Register
    {
        public static IServiceCollection RegisterContext(this IServiceCollection services, DataProvider dataProvider)
        {
            services
                .AddDbContext<MuContext>(options =>
                {
                    options
                        .UseLazyLoadingProxies()
                        .UseSqlServer(dataProvider.MuConnection);
                })
                .AddScoped<MuContext>();

            return services;
        }

        public static IServiceCollection RegisterRepository(this IServiceCollection services)
        {
            services.AddTransient<IRepository, Repository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}