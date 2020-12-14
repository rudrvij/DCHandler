
using Amazon.Lambda.Core;
using Microsoft.Extensions.DependencyInjection;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace DailyCurveHandler.Functions
{
    public class Function
    {
        public IConfigurationService ConfigService { get; }
        public Function()
        {
            // Set up Dependency Injection
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // TODO: Get service from DI system
            ConfigService = serviceProvider.GetService<IConfigurationService>();
        }

        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public string FunctionHandler(string input, ILambdaContext context)
        {
            var c = ConfigService.GetConfiguration();
            return c[input] ?? "None";
        }
        private void ConfigureServices(IServiceCollection serviceCollection)
        {
            // TODO: Register services with DI system
            serviceCollection.AddTransient<IEnvironmentService, EnvironmentService>();
            serviceCollection.AddTransient<IConfigurationService, ConfigurationService>();
        }
    }
}
