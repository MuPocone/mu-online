using Microsoft.Extensions.Configuration;
using MuOnline.Infrastruture.Application.Settings;

namespace MuOnline.Infrastruture.Application.Providers
{
    public class RouteProvider
    {
        public string UrlBase { get; }

        public RouteProvider(IConfiguration configuration)
        {
            UrlBase = configuration.GetSection(AppSettingsKeys.Route.UrlBase)?.Value;
        }
    }
}