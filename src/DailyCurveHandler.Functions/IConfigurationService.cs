using Microsoft.Extensions.Configuration;

namespace DailyCurveHandler.Functions
{
    public interface IConfigurationService
    {
        IConfiguration GetConfiguration();
    }
}
