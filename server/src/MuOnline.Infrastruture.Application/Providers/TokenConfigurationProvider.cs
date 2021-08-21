using System;
using Microsoft.Extensions.Configuration;
using MuOnline.Infrastruture.Application.Settings;

namespace MuOnline.Infrastruture.Application.Providers
{
    public class TokenConfigurationProvider
    {
        public string Secret { get; }
        public int Expiration { get; }

        public TokenConfigurationProvider(IConfiguration configuration)
        {
            Secret = configuration.GetSection(AppSettingsKeys.TokenConfiguration.Secret)?.Value;
            Expiration = Convert.ToInt32(configuration.GetSection(AppSettingsKeys.TokenConfiguration.Expiration)?.Value);
        }
    }
}