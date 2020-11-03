using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Volo.Abp.AspNetCore.ExceptionHandling;

namespace MyMessenger.WebApi.StartupFiles.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureExceptionHandling(this IServiceCollection services)
        {
            return services.Configure<AbpExceptionHandlingOptions>(options =>
            {
                options.SendExceptionsDetailsToClients = true;
            });
        }

        public static IServiceCollection AddCorsPolicy(this IServiceCollection services)
        {
            return services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.WithOrigins("http://localhost:4200") // angular port
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });
        }

        public static IServiceCollection AddSwaggerServices(this IServiceCollection services)
        {
            return services.AddSwaggerGen(
                options =>
                {
                    options.SwaggerDoc("v1", new OpenApiInfo { Title = "MyMessenger API", Version = "v1" });
                    options.DocInclusionPredicate((docName, description) => true);
                }
            );
        }
    }
}
