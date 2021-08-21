using Microsoft.Extensions.Configuration;
using MuOnline.Infrastruture.Application.Providers;

namespace MuOnline.Infrastruture.Application.Settings
{
    public class AppSettings
    {
        public TokenConfigurationProvider TokenConfiguration { get; set; }
        public SwaggerProvider Swagger { get; set; }
        public DataProvider Data { get; set; }
        public RouteProvider Route { get; set; }
        public EmailConfigurationProvider EmailConfiguration { get; set; }

        public AppSettings() { }

        public AppSettings(IConfiguration configuration)
        {
            TokenConfiguration = new TokenConfigurationProvider(configuration);
            Swagger = new SwaggerProvider(configuration);
            Data = new DataProvider(configuration);
            Route = new RouteProvider(configuration);
            EmailConfiguration = new EmailConfigurationProvider(configuration);
        }
    }
}