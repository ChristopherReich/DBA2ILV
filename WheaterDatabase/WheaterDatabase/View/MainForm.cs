using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherDatabase
{
    public partial class MainForm : Form
    {
        MongoClient client;
        IMongoDatabase db;

        public MainForm()
        {
            InitializeComponent();
            client = new MongoClient("mongodb://127.0.0.1:27017");
            db = client.GetDatabase("Wheater");
        }

        public void SetStatus(string message)
        {
            lbStatus.Text = message;
        }

    }
}
