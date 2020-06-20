using System;
using Xunit;
using ecoletaApi.Controllers;
using ecoletaApi;

namespace ecoletaApi.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void GetWeatherForecastForNextFiveDays() {
            var returnedWeatherForecast = controller.Get();

            Assert.Contains<WeatherForecast>(returnedWeatherForecast, 
                        item => item.Date.Day == DateTime.Today.AddDays(5).Day);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
