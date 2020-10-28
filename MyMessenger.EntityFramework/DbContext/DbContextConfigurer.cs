using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.DependencyInjection;

namespace MyMessenger.EntityFramework.DbContext
{
    public static class DbContextConfigurer
    {
        public static void Configure(
            IAbpDbContextRegistrationOptionsBuilder optionsBuilder,
            string connectionString, 
            Lazy<ILoggerFactory> loggerFactory)
        {
            optionsBuilder.AddDefaultRepositories(includeAllEntities: true);

            optionsBuilder.Services.Configure<AbpDbContextOptions>(abpDbContextOptions =>
            {
                abpDbContextOptions.Configure(configContext =>
                {
                    var builder = configContext.DbContextOptions;
                    builder.EnableSensitiveDataLogging();
                    builder.UseLoggerFactory(loggerFactory.Value);
                    builder.UseNpgsql(connectionString, x => x.MigrationsAssembly("MyMessenger.EntityFramework"));
                });
            });
        }
    }
}
