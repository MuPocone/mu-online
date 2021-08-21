using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using MuOnline.Infrastruture.Application.Providers;
using Newtonsoft.Json.Serialization;
using System.Text;

namespace MuOnline.WebApi.Configurations
{
    public static class WebApiConfiguration
    {
        public static IServiceCollection WebApiConfigure(this IServiceCollection services, RouteProvider route, string myAllowSpecificOrigins)
        {
            services
                .AddControllers()
                .AddNewtonsoftJson(opt =>
                {
                    opt.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                    opt.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                });

            services
                .AddAuthorization();

            services
                .AddCors(opt =>
                {
                    opt
                        .AddPolicy(myAllowSpecificOrigins,
                            cor =>
                            {
                                cor.WithOrigins(new string[]
                                {
                                    $"{route.UrlBase}"
                                });
                                cor.AllowAnyHeader();
                                cor.AllowAnyMethod();
                                cor.AllowCredentials();
                            });
                });

            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();

            return services;
        }

        public static IServiceCollection AuthenticationConfigure(this IServiceCollection services, TokenConfigurationProvider provider)
        {
            var key = Encoding.UTF8.GetBytes(provider.Secret);
            
            services
                .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(x =>
                {
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key)
                    };
                });

            return services;
        }
    }
}