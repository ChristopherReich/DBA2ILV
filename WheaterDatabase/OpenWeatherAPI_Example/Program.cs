using System;
using OpenWeatherAPI;

namespace OpenWeatherAPI_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new OpenWeatherApiClient("c8b0afac8bc6ad190b6527d7d81cf0ae");

            Console.WriteLine("OpenWeatherAPI Example Application");
            Console.WriteLine();

            Console.WriteLine("Enter city to get weather data for:");
            var city = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Fetching weather data for '{city}'");
            var results = client.Query(city);

            Console.WriteLine($"The temperature in {city} is {results.Main.Temperature.CelsiusCurrent}°C. There is {results.Wind.SpeedMetersPerSecond} m/s wind in the {results.Wind.Direction} direction.");

            Console.ReadLine();
        }
    }
}
