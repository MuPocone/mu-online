using Microsoft.Extensions.DependencyInjection;
using MuOnline.EF.DI;
using MuOnline.Infrastruture.Application.Providers;
using MuOnline.Infrastruture.Application.Settings;
using MuOnline.Services.DI;

namespace MuOnline.Application.DI
{
    public static class Register
    {
        public static IServiceCollection RegisterModules(this IServiceCollection services, DataProvider dataProvider)
        { 
            services
                .RegisterContext(dataProvider)
                .RegisterRepository()
                .RegisterServices();

            return services;
        }
    }
}
