using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WeatherDatabase.Model
{
    public class OpenWeatherApiRequest : IDisposable
    {
        private readonly string _apiKey;
        private readonly string _lat;
        private readonly string _lon;

        private readonly HttpClient _httpClient;
        private Uri _uri;

        private bool _disposed;

        public OpenWeatherApiRequest(string apiKey, string lat, string lon)
        {
            _lat = lat;
            _lon = lon;
            _apiKey = apiKey;

            string url = $"https://api.openweathermap.org/data/2.5/weather?lat={_lat}&lon={_lon}&appid={_apiKey}";
            _uri = new Uri(url);
            _httpClient = new HttpClient();
        }


        public async Task<OpenWeatherMapData> QueryAsync()
        {
            var responseString = await _httpClient.GetStringAsync(_uri).ConfigureAwait(continueOnCapturedContext: false);
            OpenWeatherMapData wheaterData = JsonConvert.DeserializeObject<OpenWeatherMapData>(responseString);
            return wheaterData;
        }

        public OpenWeatherMapData Query()
        {
            return Task.Run(async () => await QueryAsync().ConfigureAwait(continueOnCapturedContext: false)).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter()
                .GetResult();
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                }

                _httpClient.Dispose();
                _disposed = true;
            }
        }
    }


    // created out of the OpenWeather Response String

    public class Clouds
    {
        public int all { get; set; }
    }

    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public int sea_level { get; set; }
        public int grnd_level { get; set; }
    }

    public class OpenWeatherMapData
    {
        public Coord coord { get; set; }
        public List<Weather> weather { get; set; }
        public string @base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }

    public class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
        public int deg { get; set; }
        public double gust { get; set; }
    }



}
