using System;
using MyUtilities;

namespace SecondProgram

{

    class CheckWeather
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Check the comfort index in the different cities");
            WeatherUtilities.Report("Sumy", WeatherUtilities.FahrenheitToCelsius(80), 57); //~26
            WeatherUtilities.Report("Oslo", WeatherUtilities.FahrenheitToCelsius(73), 49); //~23
            WeatherUtilities.Report("London", 26, 33);  //~78.8F
        }
    }

}