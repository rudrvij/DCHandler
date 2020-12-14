using Microsoft.Extensions.Configuration;
using System.IO;

namespace DailyCurveHandler
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IEnvironmentService environmentService;

        public ConfigurationService(IEnvironmentService environmentService)
        {
            this.environmentService = environmentService;
        }
        public IConfiguration GetConfiguration()
        {
            return new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
           .AddJsonFile($"appsettings.{environmentService.EnvironmentName}.json", optional: true)
           .AddEnvironmentVariables()
           .Build();
        }
    }
}
