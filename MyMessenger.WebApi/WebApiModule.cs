using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyMessenger.Application;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Autofac;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using MyMessenger.WebApi.StartupFiles.Extensions;

namespace MyMessenger.WebApi
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpAutoMapperModule),
        typeof(ApplicationModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class WebApiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var services = context.Services;
            var configuration = services.GetConfiguration();

            services.AddCorsPolicy();
            services.ConfigureExceptionHandling();
            services.AddJwt(configuration);
            services.AddSwaggerServices();
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();
            var configuration = context.GetConfiguration();

            if (env.EnvironmentName == "Development" || env.EnvironmentName == "Docker")
            {
                app.UseSwaggerService();
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseConfiguredEndpoints();
            app.ApplyMigrations(configuration);
        }
    }
}
