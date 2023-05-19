using MySql.Data.MySqlClient;
using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bulding connection string");
            string myConnectionString = "SERVER=127.0.0.1;" +
                                        "DATABASE=fhooe;" +
                                        "UID=dba;" +
                                        "PASSWORD=dba2ilv;";

            Console.WriteLine("create connection");
            MySqlConnection connection = new MySqlConnection(myConnectionString);

            Console.WriteLine("create command");
            MySqlCommand command = connection.CreateCommand();

            Console.WriteLine("building query");
            command.CommandText = "SELECT * FROM person";
            
            MySqlDataReader Reader;
            connection.Open();
            Reader = command.ExecuteReader();
            //connection.Close();

            //Reader.Close();
            Console.WriteLine("start reading\n");
            
            while (Reader.Read())
            {
                string row = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    row += Reader.GetValue(i).ToString() + ", ";
                    
                }
                Console.WriteLine(row);
                
            }
            connection.Close();
            Console.WriteLine("Daten auslesen beendet. Taste drücken zum Beenden.");
            Console.ReadKey();
        }
    }
}
