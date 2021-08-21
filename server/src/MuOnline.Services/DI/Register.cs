using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace MuOnline.Services.DI
{
    public static class Register
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.Name.EndsWith("Service"))
                .ToDictionary(i => i.GetInterfaces()[0], t => t)
                .ToList();

            types.ForEach(srv =>
            {
                var (service, implementation) = srv;
                services.AddTransient(service, implementation);
            });

            return services;
        }
    }
}