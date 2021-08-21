using System;
using Microsoft.Extensions.Configuration;
using MuOnline.Infrastruture.Application.Settings;

namespace MuOnline.Infrastruture.Application.Providers
{
    public class EmailConfigurationProvider
    {
        public string PrimaryDomain { get; }
        public int PrimaryPort { get; }
        public string UsernameEmail { get; }
        public string UsernamePassword { get; }

        public EmailConfigurationProvider(IConfiguration configuration)
        {
            PrimaryDomain = configuration.GetSection(AppSettingsKeys.EmailConfiguration.PrimaryDomain)?.Value;
            PrimaryPort = Convert.ToInt32(configuration.GetSection(AppSettingsKeys.EmailConfiguration.PrimaryPort)?.Value);
            UsernameEmail = configuration.GetSection(AppSettingsKeys.EmailConfiguration.UsernameEmail)?.Value;
            UsernamePassword = configuration.GetSection(AppSettingsKeys.EmailConfiguration.UsernamePassword)?.Value;

        }
    }
}