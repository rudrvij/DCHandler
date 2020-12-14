using System;
using static DailyCurveHandler.Functions.Constants;

namespace DailyCurveHandler.Functions
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
