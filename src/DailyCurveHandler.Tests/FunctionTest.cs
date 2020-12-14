
using Xunit;
using Amazon.Lambda.TestUtilities;

namespace DailyCurveHandler.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestToUpperFunction()
        {

            // Invoke the lambda function and confirm the string was upper cased.
            var function = new Function();
            var context = new TestLambdaContext();
            var val = function.FunctionHandler("env1", context);
                        
            Assert.Equal("val1", val);
        }
    }
}
