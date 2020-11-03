using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using MyMessenger.EntityFramework.DbContext;

namespace MyMessenger.WebApi.StartupFiles.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseSwaggerService(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "MyMessenger API");
            });

            return app;
        }

        public static IApplicationBuilder ApplyMigrations(this IApplicationBuilder app, IConfiguration configuration)
        {
            Automigrator.Migrate(configuration.GetConnectionString("PostgreSQL"));

            return app;
        }
    }
}
