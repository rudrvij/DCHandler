using Microsoft.Extensions.Configuration;

namespace DailyCurveHandler
{
    public interface IConfigurationService
    {
        IConfiguration GetConfiguration();
    }
}
