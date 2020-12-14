using System;
using static DailyCurveHandler.Constants;

namespace DailyCurveHandler
{
    public class EnvironmentService : IEnvironmentService
    {
        public EnvironmentService()
        {
            EnvironmentName = Environment.GetEnvironmentVariable(EnvironmentVariables.AspnetCoreEnvironment) ?? Environments.Production;
        }
        public string EnvironmentName { get; set; }
    }
}
