using Microsoft.Extensions.DependencyInjection;
using MuOnline.Infrastructure.Identity.Core;

namespace MuOnline.Infrastructure.Identity.DI
{
    public static class Register
    {
        public static IServiceCollection RegisterAuthentication(this IServiceCollection services) => services.AddTransient<IAuthentication, Authentication>();
    }
}