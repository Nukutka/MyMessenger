using Microsoft.Extensions.DependencyInjection;
using MyMessenger.Core;
using MyMessenger.Security.Hash;
using MyMessenger.Security.Hash.Abstraction;
using MyMessenger.Security.Jwt;
using Volo.Abp.Modularity;

namespace MyMessenger.Security
{
    [DependsOn(typeof(CoreModule))]
    public class SecurityModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddTransient<IHashFunction, StreebogProvider>();
            context.Services.AddTransient<IJwtGenerator, JwtProvider>();
        }
    }
}
