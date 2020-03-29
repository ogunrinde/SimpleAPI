using System;
using SimpleAPI.Controllers;
using Xunit;
//using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {

        }
        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void GetReturnsCorrectNumber()
        {
        var returnValue = controller.GetString(1);
        Assert.Equal("Les Jacksoning", returnValue.Value);
        }
    }
}
