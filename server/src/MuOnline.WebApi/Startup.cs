using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MuOnline.Application.DI;
using MuOnline.Infrastructure.Identity.DI;
using MuOnline.Infrastruture.Application.Settings;
using MuOnline.WebApi.Configurations;

namespace MuOnline.WebApi
{
    public class Startup
    { 
        public IConfiguration Configuration { get; }
        private readonly AppSettings _appSettings; 
        private readonly string _myAllowSpecificOrigins = "myAllowSpecificOriginsPolicy";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _appSettings = new AppSettings(configuration);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .SwaggerConfigurationService(_appSettings.Swagger)
                .RegisterModules(_appSettings.Data)
                .RegisterAuthentication()
                .AuthenticationConfigure(_appSettings.TokenConfiguration)
                .WebApiConfigure(_appSettings.Route, _myAllowSpecificOrigins);
             
            services
                .Configure<AppSettings>(app =>
                {
                    app.Data = _appSettings.Data;
                    app.TokenConfiguration = _appSettings.TokenConfiguration;
                    app.Route = _appSettings.Route;
                    app.EmailConfiguration = _appSettings.EmailConfiguration;
                });
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(_myAllowSpecificOrigins);

            app
                .UseAuthentication()
                .UseAuthorization();

            app.SwaggerConfigurationApplication(_appSettings.Swagger);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
