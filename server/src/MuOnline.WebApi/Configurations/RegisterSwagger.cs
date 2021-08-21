using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using MuOnline.Infrastruture.Application.Providers;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace MuOnline.WebApi.Configurations
{
    public static class RegisterSwagger
    {
        public static IServiceCollection SwaggerConfigurationService(this IServiceCollection services, SwaggerProvider provider)
        {
            services
                .AddSwaggerGen(c =>
            {
                c.SwaggerDoc(provider.Version, new OpenApiInfo
                {
                    Title = provider.Title,
                    Version = provider.Version,
                    Description = provider.Description
                });
            });

            return services;
        }

        public static IApplicationBuilder SwaggerConfigurationApplication(this IApplicationBuilder app, SwaggerProvider provider)
        {
            app
                .UseSwagger()
                .UseSwaggerUI(cfg =>
                {
                    cfg.SwaggerEndpoint(provider.Url, provider.Name);
                    cfg.DocExpansion(DocExpansion.None);
                });

            return app;
        }
    }
}