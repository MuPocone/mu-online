namespace MuOnline.Infrastruture.Application.Settings
{
    public struct AppSettingsKeys
    {
        public struct Swagger
        {
            public const string Version = "Swagger:Version";
            public const string Title = "Swagger:Title";
            public const string Description = "Swagger:Description";
            public const string Name = "Swagger:Name";
            public const string Url = "Swagger:Url";
        }

        public struct TokenConfiguration
        {
            public const string Expiration = "TokenConfigurations:Expiration";
            public const string Secret = "TokenConfigurations:Secret";
        }

        public struct DataMuConnection
        {
            public const string StringConnection = "DataMuConnection:StringConnection"; 
        }

        public struct Route
        {
            public const string UrlBase = "Route:UrlBase";
        }

        public struct EmailConfiguration
        {
            public const string PrimaryDomain = "EmailConfigurations:PrimaryDomain";
            public const string PrimaryPort = "EmailConfigurations:PrimaryPort";
            public const string UsernameEmail = "EmailConfigurations:UsernameEmail";
            public const string UsernamePassword = "EmailConfigurations:UsernamePassword";
        }
    }
}