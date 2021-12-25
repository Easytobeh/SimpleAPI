using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{
    WeatherForecastController controller = new WeatherForecastController();
    [Fact]
    public  void GetReturnsMyName()
    {
        var returnValue = controller.Let(); 
        Assert.Equal("Destroy the World!", returnValue.Value); 
    }

    [Fact]
    public void Test1()
    {

    }
}