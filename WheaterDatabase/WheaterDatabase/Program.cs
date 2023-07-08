using Amazon.Runtime.Internal.Auth;
using OpenWeatherAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using WeatherDatabase.Model;
using MongoDB.Bson;
using MongoDB.Driver;
using WeatherDatabase.Controller;

namespace WeatherDatabase
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            DatabaseController appController = new DatabaseController();
                
        }


    }
}
