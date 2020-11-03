using Microsoft.Extensions.Configuration;
using Volo.Abp;

namespace MyMessenger.Core.Configuration
{
    public static class AppConfigExtensions
    {
        public static string GetJwtSecretKey(this IConfiguration configurationRoot)
        {
            var secretKey = configurationRoot.GetSection("JwtOptions:SecretKey")?.Value;

            return secretKey
                ?? throw new UserFriendlyException("appsettings not contain JwtOptions:SecretKey.");
        }
    }
}
