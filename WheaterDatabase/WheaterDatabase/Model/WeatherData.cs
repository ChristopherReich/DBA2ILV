using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json.Linq;
using OpenWeatherAPI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDatabase.Model
{

    [BsonIgnoreExtraElements]
    public class WeatherData
    {

        /// <summary>
        /// Creates a Weather Dataset for the database
        /// </summary>
        /// <param name="data"></param>
        public WeatherData(OpenWeatherMapData data)
        {
            temperature = data.main.temp - 273.15; // [temperature] = °C
            windSpeed = data.wind.speed * 3.6; 
            pressure = data.main.pressure; // [pressure] = hPa

            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            timestamp = dateTime.AddSeconds(data.dt).ToLocalTime();

            metadata = "Bruck8-WIPP";
        }

        [BsonId]
        public ObjectId ID { get; set; }

        [BsonElement("timestamp")]
        public DateTime timestamp { get; set; }

        [BsonElement("location")]
        public string metadata { get; set; }

        [BsonElement("temperature")]
        public double temperature { get; set; }

        [BsonElement("wind")]
        public double windSpeed { get; set; }

        [BsonElement("pressure")]
        public double pressure { get; set; }
    }

}

