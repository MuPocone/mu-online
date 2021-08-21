using Microsoft.Extensions.Configuration;
using MuOnline.Infrastruture.Application.Settings;

namespace MuOnline.Infrastruture.Application.Providers
{
    public class DataProvider
    {
        public string MuConnection { get; } 

        public DataProvider(IConfiguration configuration)
        {
            MuConnection = configuration.GetSection(AppSettingsKeys.DataMuConnection.StringConnection)?.Value;
        }
    }
}