using Microsoft.Extensions.Configuration;
using MuOnline.Infrastruture.Application.Settings;

namespace MuOnline.Infrastruture.Application.Providers
{
    public class SwaggerProvider
    {
        public string Name { get; }
        public string Version { get; }
        public string Title { get; }
        public string Description { get; }
        public string Url { get; }

        public SwaggerProvider(IConfiguration configuration)
        {
            Version = configuration.GetSection(AppSettingsKeys.Swagger.Version)?.Value;
            Title = configuration.GetSection(AppSettingsKeys.Swagger.Title)?.Value;
            Description = configuration.GetSection(AppSettingsKeys.Swagger.Description)?.Value;
            Name = configuration.GetSection(AppSettingsKeys.Swagger.Name)?.Value;
            Url = configuration.GetSection(AppSettingsKeys.Swagger.Url)?.Value;
        }
    }
}