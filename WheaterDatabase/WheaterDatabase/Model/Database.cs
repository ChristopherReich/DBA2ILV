using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDatabase.Model
{
    public class Database
    {
        private MongoClient _clientDb;
        private IMongoDatabase _db;


        public Database(string name)
        {
            _clientDb = new MongoClient("mongodb://127.0.0.1:27017");
            _db = _clientDb.GetDatabase(name);
        }
        
        public void CreateCollection(string collection)
        {
            _db.CreateCollection(collection);
        }


        public void AddData(string collection, WeatherData data)
        {
            var weathercollection = _db.GetCollection<WeatherData>(collection);
            weathercollection.InsertOne(data);
        }


        public void CreateSampleDataset(string collection)
        {
            List<WeatherData> data = new List<WeatherData>();
            var weathercollection = _db.GetCollection<WeatherData>(collection);
            weathercollection.InsertMany(data);
        }




    }
}
