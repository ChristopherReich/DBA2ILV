using Microsoft.VisualBasic.Logging;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherDatabase.Model;

namespace WeatherDatabase.Controller
{
    internal class DatabaseController
    {

        private readonly MainForm view;

        string key = "c8b0afac8bc6ad190b6527d7d81cf0ae";
        string lat = "48.21447505047061";
        string lon = "13.399023258618133";

        public Database weatherDb;



        public DatabaseController()
        {
            

            weatherDb = new Database("WeatherDatabase");
            weatherDb.CreateCollection("Weather");

            this.Run();

            view = new MainForm();
            Application.Run(view);
        }


        private void Run()
        {
            Task addDataTask = new Task(() => { AddData(); });
            addDataTask.Start();
        }

        private void AddData()
        {
            while (true)
            {
                var request = new OpenWeatherApiRequest(key, lat, lon);
                var results = request.Query();
                WeatherData data = new WeatherData(results);
                
                weatherDb.AddData("Weather", data);
                
                System.Threading.Thread.Sleep(10 * 1000);
            }
            
        }
    }
}
