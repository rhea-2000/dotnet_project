using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using SonarTestApi.Controllers;

namespace Weatherreport.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var logger = Mock.Of<ILogger<WeatherForecastController>>();
            WeatherForecastController controller = new WeatherForecastController(logger);
            int count = controller.Get();
            Assert.AreEqual(5, count);
        }
    }
}